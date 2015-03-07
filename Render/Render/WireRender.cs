﻿using System;
using System.Drawing;
using System.Numerics;
using Render.Shaders;

namespace Render
{
    public class WireRender: IRender
    {
        private int _width;
        private int _height;

        public void Init(int width, int height)
        {
            _width = width;
            _height = height;
        }

        unsafe public void Draw(int faceIndex, byte* bitmap, IShader shader, ShaderState shaderState, int startY, int endY)
        {
            shaderState.Vertex.Clear();
            var v0 = shader.Vertex(shaderState.Vertex, faceIndex, 0);
            var v1 = shader.Vertex(shaderState.Vertex, faceIndex, 1);
            var v2 = shader.Vertex(shaderState.Vertex, faceIndex, 2);

            var screenCoords = new[]
            {
                new Vector3(v0.X/v0.W, v0.Y/v0.W, v0.Z/v0.W),
                new Vector3(v1.X/v1.W, v1.Y/v1.W, v1.Z/v1.W),
                new Vector3(v2.X/v2.W, v2.Y/v2.W, v2.Z/v2.W)
            };

            Line((int)screenCoords[0].X, (int)screenCoords[0].Y, (int)screenCoords[1].X, (int)screenCoords[1].Y, bitmap, Color.White, startY, endY);
            Line((int)screenCoords[1].X, (int)screenCoords[1].Y, (int)screenCoords[2].X, (int)screenCoords[2].Y, bitmap, Color.White, startY, endY);
            Line((int)screenCoords[2].X, (int)screenCoords[2].Y, (int)screenCoords[0].X, (int)screenCoords[0].Y, bitmap, Color.White, startY, endY);
        }

        unsafe private void Line(int x0, int y0, int x1, int y1, byte* bmp, Color color, int startY, int endY)
        {
            var vertOrientation = Math.Abs(x1 - x0) < Math.Abs(y1 - y0);

            if (vertOrientation)
            {
                int buf;

                buf = x0;
                x0 = y0;
                y0 = buf;

                buf = x1;
                x1 = y1;
                y1 = buf;
            }
            if (x0 > x1)
            {
                int buf;

                buf = x0;
                x0 = x1;
                x1 = buf;

                buf = y0;
                y0 = y1;
                y1 = buf;
            }

            int errorMul = 0;

            int sign = Math.Sign(y1 - y0);

            int kMul = 2 * (y1 - y0);
            int halfMul = x1 - x0;
            int oneMul = 2 * halfMul;

            int y = y0;
            for (var x = x0; x <= x1; x++)
            {
                errorMul += kMul;
                if (Math.Abs(errorMul) > halfMul)
                {
                    y += sign;
                    errorMul -= sign * oneMul;
                }

                if (vertOrientation)
                {
                    if (y >= 0 && y < _width && x >= startY && x <= endY)
                    {
                        var foo = ((_height - x - 1) * _width + y) * 4;
                        bmp[foo + 2] = color.R;
                        bmp[foo + 1] = color.G;
                        bmp[foo + 0] = color.B;
                    }
                }
                else
                {
                    if (x >= 0 && x < _width && y >= startY && y <= endY)
                    {
                        var foo = ((_height - y - 1) * _width + x) * 4;
                        bmp[foo + 2] = color.R;
                        bmp[foo + 1] = color.G;
                        bmp[foo + 0] = color.B;
                    }
                }
            }
        }
    }
}