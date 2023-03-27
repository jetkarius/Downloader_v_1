using AngleSharp.Io;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;
using YoutubeExplode.Videos.Streams;

namespace Downloader_v_1
{
    class Receiver
    {
        public void Operation()
        {

            Console.WriteLine("\n Введите Url Видео.");
            string videoUrl = Console.ReadLine();

            GetAsync(videoUrl);

            Console.ReadKey();

            Console.WriteLine("\n Начинаю скачивание.");

            DownloadAsync(videoUrl);

            Console.ReadKey();

            static async Task GetAsync(string videoUrl)
            {
                var youtube = new YoutubeClient();
                Console.WriteLine("\n Получаю информацию о видео.");

                var video = await youtube.Videos.GetAsync(videoUrl);

                Console.WriteLine($"\n{videoUrl}");
                Console.WriteLine($"\n{video.Title}");
                Console.WriteLine($"\n{video.UploadDate.DateTime.ToLongDateString()}");
                Console.WriteLine($"\n{video.Duration}");
            }

            static async Task DownloadAsync(string videoUrl)
            {
                var youtube = new YoutubeClient();

                var video = await youtube.Videos.GetAsync(videoUrl);

                using var progress = new ProgressIndicator();
                await youtube.Videos.DownloadAsync(videoUrl, "Video.mp4", progress);

                Console.WriteLine("Скачивание завершено.");
            }
        }
    }
}

