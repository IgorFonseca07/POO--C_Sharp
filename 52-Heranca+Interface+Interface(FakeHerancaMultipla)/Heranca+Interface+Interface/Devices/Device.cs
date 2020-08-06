namespace Heranca_Interface_Interface.Devices
{
    abstract class Device
    {
        public int SerialNumber { get; set; }

        protected Device(int serialNumber)
        {
            SerialNumber = serialNumber;
        }

        public abstract void ProcessDoc(string document);
    }
}
