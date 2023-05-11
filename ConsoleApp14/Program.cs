class Card
{
    private string number;
    private string clientFIO;
    private string validity;
    private string secureCode;
    private string type;

    public Card()
    {
        number = "";
        clientFIO = "";
        validity = "";
        secureCode = "";
        type = "";
    }

    public Card(string number, string clientFIO, string validity, string secureCode, string type)
    {
        this.number = number;
        this.clientFIO = clientFIO;
        this.validity = validity;
        this.secureCode = secureCode;
        this.type = type;
    }

    public Card(string number, string clientFIO, string validity, string secureCode)
    {
        this.number = number;
        this.clientFIO = clientFIO;
        this.validity = validity;
        this.secureCode = secureCode;
        this.type = "дебетовая";
    }

    public Card(string number, string clientFIO, string validity)
    {
        this.number = number;
        this.clientFIO = clientFIO;
        this.validity = validity;
        this.secureCode = "000";
        this.type = "дебетовая";
    }

    public void PrintInfo()
    {
        Console.WriteLine("Номер карты: " + number);
        Console.WriteLine("ФИО клиента: " + clientFIO);
        Console.WriteLine("Срок действия: " + validity);
        Console.WriteLine("Код безопасности: " + secureCode);
        Console.WriteLine("Тип карты: " + type);
    }
}
