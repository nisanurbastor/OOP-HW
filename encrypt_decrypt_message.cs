/*    #ASSIGNMENT 2#
 * 
 *    STUDENT NAME: NİSANUR BAŞTOR
 *    NUMBER .....: B201202044
 * 
 */


using System;

interface ICrypt
{
    string message { set; get; }
    string password { set; get; }
    string repeatPassword();
    string encrypt();
    string decrypt();
    void printEncryptedMessage();
    void printDecryptedMessage();

}
class CRYPT:ICrypt
{
    public string message { set; get; }
    public string password { set; get; }


    public CRYPT()
    {
        Console.Write("ENTER A PASSWORD...: ");
        password = Console.ReadLine();
        Console.Write("ENTER A MESSAGE....: ");
        message = Console.ReadLine();
        Console.WriteLine("---------------------------------------");
        Console.WriteLine("PASSWORD...........: " + password);
        Console.WriteLine("MESSAGE............: " + message);
        Console.WriteLine("---------------------------------------");
    }
    public string repeatPassword()
    {
        for (int i=0;i<message.Length;i++)
        {
            if (message.Length == password.Length)
                break;
            else if(password.Length < message.Length)
            {
                if (char.IsWhiteSpace(message[i]))
                    password += (char)(32) ;
                else if(char.IsLetter(message[i]))
                    password += password[i];
            }
        }
        return password;
    }

    public string encrypt()
    {
        password = repeatPassword();
        string encryptedMessage = null;
        for (int i = 0; i<message.Length; i++)
        {
            int x = (password[i] + message[i]) % 26;
            encryptedMessage += (char)(x+65);
        }
        return encryptedMessage;
    }

    public string decrypt()
    {
        password = repeatPassword();
        string encryptedMessage = encrypt();
        string decryptedMessage = null;

        for (int i=0;i<message.Length;i++)
        {
            int x = (encryptedMessage[i] - password[i] + 26) % 26;

            decryptedMessage += (char)(x+65);
        }

        return decryptedMessage;
    }

    public void printEncryptedMessage()
    {
        Console.WriteLine("ENCRYPTED MESSAGE..: " + encrypt());
    }

    public void printDecryptedMessage()
    {
        Console.WriteLine("DECRYPTED MESSAGE..: " + decrypt());
    }
}
    class Program
{
    static void Main(string[] args)
    {
        CRYPT input = new CRYPT();
        input.printEncryptedMessage();
        input.printDecryptedMessage();
    }
}