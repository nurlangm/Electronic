using System;

namespace Class
{
    class Electronic
    {

        public string Model;
        public string Prosessor;
        public string Video;
        public string Ram;


        public Electronic(string model, string prosessor, string video, string ram)
        {
            Model = model;
            Prosessor = prosessor;
            Video = video;
            Ram = ram;
        }


        public string ElectronicInfo()
        {

            return $"{Model} {Prosessor} {Video} {Ram}";
        }


    }
}

