using System;
using System.Text.Json;

namespace Aula15
{
    class TV : RemoteControl
    {
        static void Main()
        {
            TV samsung = new TV();
            samsung.Connect();
            samsung.IncreaseVolume();
            samsung.ChangeChannel(12);

            var json = JsonSerializer.Serialize(samsung, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            Console.WriteLine(json);
        }
    }

    class RemoteControl
    {
        // ✅ Campos privados
        private bool connected;
        private int volume;
        private int channel;

        // ✅ Propriedades públicas somente para leitura (para JSON e acesso externo)
        public bool Connected => connected;
        public int Volume => volume;
        public int Channel => channel;

        // ✅ Métodos GET/SET (com lógica)
        public bool GetConnectionStatus() => connected;
        public void Connect() => connected = true;
        public void Disconnect() => connected = false;

        public int GetVolume() => volume;
        public void IncreaseVolume() => volume++;
        public void DecreaseVolume() => volume--;

        public int GetChannel() => channel;
        public void ChangeChannel(int newChannel) => channel = newChannel;
    }
}
    