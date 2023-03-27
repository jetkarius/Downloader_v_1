using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Reflection;
using System.Threading;
using YoutubeExplode;

namespace Downloader_v_1
{
    class Programm
    {
        static void Main()
        {
            Console.WriteLine("\n Загрузчик приветствует вас.\n Давайте начнём работу.");

            
            
            var sender = new Sender();

            var receiver = new Receiver();

            var downloader = new Downloader(receiver);

            sender.SetCommand(downloader);

            sender.Run();
        }
    }
}