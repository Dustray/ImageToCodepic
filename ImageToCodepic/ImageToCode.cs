﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageToCodepic
{
    class ImageToCode
    {

        Form1 generateProgressBar;
        public ImageToCode(Form1 generateProgressBar)
        {
            this.generateProgressBar = generateProgressBar;
        }
        public string ToCodeFromImage(Image img)
        {
            Bitmap bitmap = new Bitmap(img);
            return BitmapToCode(bitmap);
            // return BitmapToCodeCom(bitmap, 19,10);
        }

        public string ToCodeFromBitmap(Bitmap bitmap)
        {
            return "";
        }

        private string BitmapToCode(Bitmap bitmap)
        {
            //char[] charPreset = { 'M', 'W', '$', '&', 'V', '%', '*', '0', '!', '1', 'i', ':', '|', '.', ' ' };//预置代替字符
            char[] charPreset = { ' ', ' ', '.', '.',',', ':', ',', ':', '|', 'i', '1', '!','/',']','I', 'o', '0', 'G', '*', '%', 'K', '&', '$', 'W', 'M', 'M' };//预置代替字符
            StringBuilder result = new StringBuilder();

            int bitHeight = bitmap.Height;
            int bitWidth = bitmap.Width;
            //double everyCharWidth = 678 / 111;
            double precision = 18;//精度，数越小越清晰


            int bitCol = (int)(precision * ((float)6 / 11));//单位区域像素宽//宽度补偿
            int bitRow = (int )precision;//单位区域像素高

            int areaXCount = bitWidth / bitCol; //1000/10像素=100个区域
            int areaYCount = bitHeight / bitRow;//700 /7个像素=100 个区域
            Console.WriteLine("像素数：" + bitHeight + "/" + bitWidth
                + "    单位区域高宽：" + bitRow + "/" + bitCol
                + "    区域个数:" + areaYCount + "/" + areaXCount);
            for (int bitH = 0; bitH < areaYCount; bitH++)
            {
                generateProgressBar.setProgressBar( (int)((float)bitH / areaYCount * 100));

                for (int bitW = 0; bitW < areaXCount; bitW++)
                {
                    float averBright = 0;

                    //获取到第bitW和第bitH区域的像素
                    for (int i = 0; i < bitRow; i++)
                    {
                        //Console.WriteLine( bitW * bitCol + i);
                        for (int j = 0; j < bitCol; j++)
                        {
                            try
                            {
                                Color color = bitmap.GetPixel(bitW * bitCol + j, bitH * bitRow + i);
                                averBright += color.GetBrightness();//获取亮度
                            }
                            catch (ArgumentOutOfRangeException)
                            {
                                averBright += 0;
                            }

                        }
                    }
                    //Console.WriteLine("亮度："+ averBright);
                    averBright /= (bitRow * bitCol);
                    int index = (int)(averBright * charPreset.Length);
                    if (index == charPreset.Length)
                        index--;
                    //Console.WriteLine(charPreset.Length - 1 - index);
                    result.Append(charPreset[charPreset.Length - 1 - index]);

                }
                result.Append("\r\n");

            }
            generateProgressBar.setProgressBar(100);
            return result.ToString();
        }
    }
}
