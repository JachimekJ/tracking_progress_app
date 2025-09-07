// Tu powstaje program do śledzenia progresu w nauce ASP.NET.
// Założenia:
/*************************************************************
 * Użytkownik może wyświetlić menu z opcjami:
    *Wybierz opcję z listy:
    *1. Dodaj rozdział nuaki ----> Dodaj moduł ----> Dodaj lekcję ----> Dodaj opis.
    *2. Wyświetl listę rozdziałów, modułów, lekcję i opis.
    *3. Zaktualizuj postęp nauki (np. oznacz jako ukończone).
    *4. Edytuj istniejący rozdział, moduł, lekcję lub opis.
    *5. Usuń rozdział, moduł, lekcję lub opis.
    *6. Zapisz postęp do pliku.
    *7. Wczytaj postęp z pliku.
    *8. Wyjdź z programu.
 * Składniki:
    *Rozdział (Chapter) - zawiera tytuł i listę modułów.
    *Moduł (Module) - zawiera tytuł i listę lekcji.
    *Lekcja (Lesson) - zawiera tytuł, opis i status ukończenia.
 * Składniki programu:
    * Logika do zarządzania strukturą nauki (dodawanie, edytowanie, usuwanie).
    * GUI lub interfejs konsolowy do interakcji z użytkownikiem.
    * Baza danych lub plik do przechowywania postępu nauki.
*/

// Menu główne programu
using System;
using System.ComponentModel.Design;
using System.IO.Pipelines;
{
    string? readResult;
    string menu = "";
    do
    {
        Console.Clear();
        Console.WriteLine("Witaj w programie do śledzenia progresu w nauce ASP.NET!");
        Console.WriteLine("Wybierz opcję z listy:");
        Console.WriteLine("\n1. Dodaj rozdział nauki");
        Console.WriteLine("2. Wyświetl ścieżkę nauki");
        Console.WriteLine("3. Zaktualizuj postęp nauki");
        Console.WriteLine("4. Edytuj wybraną pozycję");
        Console.WriteLine("5. Usuń wybraną pozycję");
        Console.WriteLine("6. Zapisz postęp do pliku");
        Console.WriteLine("7. Wczytaj postęp z pliku");
        Console.WriteLine("8. Zakończ program");

        readResult = Console.ReadLine();
        if (readResult != null)
        {
            menu = readResult.ToLower();
        }

        switch (menu)
        {
            case "1":
                Console.WriteLine("In progress");
                Console.WriteLine("Naciśnij enter, aby kontynuować...");
                readResult =Console.ReadLine();
                break;
            case "2":
                Console.WriteLine("In progress");
                Console.WriteLine("Naciśnij enter, aby kontynuować...");
                readResult = Console.ReadLine();
                break;
            case "3":
                Console.WriteLine("In progress");
                Console.WriteLine("Naciśnij enter, aby kontynuować...");
                readResult = Console.ReadLine();
                break;
            case "4":
                Console.WriteLine("In progress");
                Console.WriteLine("Naciśnij enter, aby kontynuować...");
                readResult = Console.ReadLine();
                break;
            case "5":
                Console.WriteLine("In progress");
                Console.WriteLine("Naciśnij enter, aby kontynuować...");
                readResult = Console.ReadLine();
                break;
            case "6":
                Console.WriteLine("In progress");
                Console.WriteLine("Naciśnij enter, aby kontynuować...");
                readResult = Console.ReadLine();
                break;
            case "7":
                Console.WriteLine("In progress");
                Console.WriteLine("Naciśnij enter, aby kontynuować...");
                readResult = Console.ReadLine();
                break;
            default:
                break;
        }
    } while (menu != "8");




}