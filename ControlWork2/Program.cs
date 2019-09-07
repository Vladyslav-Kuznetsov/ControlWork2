using System;
using DataStruct;

namespace ControlWork2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<File> result = new List<File>();
            string input = @"Text:file.txt(6B);Some string content
Image:img.bmp(19MB);1920x1080
Text:data.txt(12B);Another string
Text:data1.txt(7B);Yet another string
Movie:logan.2017.mkv(19GB);1920x1080;2h12m";

            string[] files = input.Split(new string[] { Environment.NewLine }, StringSplitOptions.RemoveEmptyEntries);

            for (int i = 0; i < files.Length; i++)
            {
                string[] split = files[i].Split(':');
                string fileType = split[0].ToLower();

                switch (fileType)
                {
                    case "text":
                        Text textFile = new Text();
                        textFile.Separator(split[1]);
                        result.Add(textFile);
                        break;
                    case "image":
                        Images imageFile = new Images();
                        imageFile.Separator(split[1]);
                        result.Add(imageFile);
                        break;
                    case "movie":
                        Movies movieFile = new Movies();
                        movieFile.Separator(split[1]);
                        result.Add(movieFile);
                        break;
                    default:
                        break;
                }
            }

            for (int i = 0; i < result.Count; i++)
            {
                Console.WriteLine(result[i]);
            }

            Console.ReadLine();
        }
    }
}
