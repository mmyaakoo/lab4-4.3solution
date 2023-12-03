// Interface for devices that can connect to a network
interface IConnectable
{
    void Connect(Computer other);
    void Disconnect(Computer other);
    void TransferData(Computer other, string data);
}