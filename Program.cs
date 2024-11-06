using System;

// initialize variables - graded assignments 
decimal[] sophia = [90, 86, 87, 98, 100, 100, 100];
decimal[] andrew = [92, 89, 81, 96, 90];
decimal[] emma = [90, 85, 87, 98, 68];
decimal[] logan = [90, 95, 87, 88, 96];

decimal[][] listEtudiant = [sophia, andrew, emma, logan];

decimal[] moyennes = new decimal[5];
decimal totalNotes = 0;
string noteFinale = "";
string[] listeNotesFinale = new string[5];
int i = 0;
int j = 0;

foreach(decimal[] etudiant in listEtudiant){
    foreach(decimal note in etudiant){
        if(j>=5){
            totalNotes += note * 0.1m;
            Console.WriteLine($"TotalNotes : {totalNotes}");
            Console.WriteLine($"note bonus : {note * 0.1m}");

        }else {
            totalNotes += note;
        }
        Console.WriteLine($"j : {j}");
        j++;
    }
    j=0;
    moyennes[i] = totalNotes / 5m;
    totalNotes = 0;

    if((moyennes[i] >= 0) && (moyennes[i] < 59)){
        noteFinale = "F";
    } else if((moyennes[i] >= 59) && (moyennes[i] < 62)){
        noteFinale = "D-";
    } else if((moyennes[i] >= 62) && (moyennes[i] < 66)){
        noteFinale = "D";
    } else if((moyennes[i] >= 66) && (moyennes[i] < 69)){
        noteFinale = "D+";
    } else if((moyennes[i] >= 69) && (moyennes[i] < 72)){
        noteFinale = "C-";
    } else if((moyennes[i] >= 72) && (moyennes[i] < 76)){
        noteFinale = "C";
    } else if((moyennes[i] >= 76) && (moyennes[i] < 79)){
        noteFinale = "C+";
    } else if((moyennes[i] >= 79) && (moyennes[i] < 82)){
        noteFinale = "B-";
    } else if((moyennes[i] >= 82) && (moyennes[i] < 86)){
        noteFinale = "B";
    } else if((moyennes[i] >= 86) && (moyennes[i] < 89)){
        noteFinale = "B+";
    } else if((moyennes[i] >= 89) && (moyennes[i] < 92)){
        noteFinale = "A-";
    } else if((moyennes[i] >= 92) && (moyennes[i] < 96)){
        noteFinale = "A";
    } else if((moyennes[i] >= 96) && (moyennes[i] <= 100)){
        noteFinale = "A+";
    }

    listeNotesFinale[i] += noteFinale;

    i++;
    Console.WriteLine("\n\n\n");
}


Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + listeNotesFinale[0]);
Console.WriteLine("Andrew:\t\t" + listeNotesFinale[1]);
Console.WriteLine("Emma:\t\t" + listeNotesFinale[2]);
Console.WriteLine("Logan:\t\t" + listeNotesFinale[3]);

Console.WriteLine("Student\t\tGrade\n");
Console.WriteLine("Sophia:\t\t" + moyennes[0]);
Console.WriteLine("Andrew:\t\t" + moyennes[1]);
Console.WriteLine("Emma:\t\t" + moyennes[2]);
Console.WriteLine("Logan:\t\t" + moyennes[3]);

Console.WriteLine("Press the Enter key to continue");      
Console.ReadLine();
