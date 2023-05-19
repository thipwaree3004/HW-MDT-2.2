using System;

class Program
{
    static void Main()
    {
        do
        {
            Console.Write("Enter a half DNA sequence: ");
            string halfDNASequence = Console.ReadLine();

            if (IsValidSequence(halfDNASequence))
            {
                Console.WriteLine("Current half DNA sequence: " + halfDNASequence);
                Console.Write("Do you want to replicate it? (Y/N): ");
                char choice = char.ToUpper(Console.ReadKey().KeyChar);
                Console.WriteLine();

                if (choice == 'Y')
                {
                    string replicatedSequence = ReplicateSeqeunce(halfDNASequence);
                    Console.WriteLine("Replicated half DNA sequence: " + replicatedSequence);
                }
                else if (choice != 'N')
                {
                    Console.WriteLine("Please input Y or N.");
                    continue;
                }
            }
            else
            {
                Console.WriteLine("That half DNA sequence is invalid.");
            }

            Console.Write("Do you want to process another sequence? (Y/N): ");
            char restartChoice = char.ToUpper(Console.ReadKey().KeyChar);
            Console.WriteLine();

            if (restartChoice == 'N')
            {
                break;
            }
            else if (restartChoice != 'Y')
            {
                Console.WriteLine("Please input Y or N.");
            }

        } while (true);
    }

    static bool IsValidSequence(string halfDNASequence)
    {
        foreach (char nucleotide in halfDNASequence)
        {
            if (!"ATCG".Contains(nucleotide))
            {
                return false;
            }
        }
        return true;
    }

    static string ReplicateSeqeunce(string halfDNASequence)
    {
        string result = "";
        foreach (char nucleotide in halfDNASequence)
        {
            result += "TAGC"["ATCG".IndexOf(nucleotide)];
        }
        return result;
    }
}

