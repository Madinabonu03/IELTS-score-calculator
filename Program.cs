using System;
System.Console.WriteLine("IELTS score average FOR academic");
string isContinued;
do 
{
decimal [] score=new decimal[4];
System.Console.Write("Enter your speking score:");
string speakingInput=Console.ReadLine();
score[0]=Convert.ToDecimal(speakingInput);
System.Console.Write("Enter your writing score:");
string writingInput=Console.ReadLine();
score[1]=Convert.ToDecimal(writingInput);
System.Console.Write("Enter your listening score:");
string listeningInput=Console.ReadLine();
score[2]=Convert.ToDecimal(listeningInput);
System.Console.Write("Enter your reading score:");
string readingInput=Console.ReadLine();
score[3]=Convert.ToDecimal(readingInput);
decimal averageScore=score.Average();
decimal reminder=averageScore-(int)averageScore;
if(reminder<25)
{
    reminder=0;
}
else if (reminder<75 && reminder>25 )
{
    reminder=0.5m;
}
else {
    reminder=1;
}
averageScore=(int)averageScore+reminder;

string scoreLevel=averageScore switch
{
    _ when averageScore==9=>@"""Expert""",
    _ when averageScore>=8 && averageScore<9=>@"""Very good""",
    _ when averageScore>=7 && averageScore<8=>@"""Good""",
    _ when averageScore>=6 && averageScore<7=>@"""Compotent"" ",
    _ => "This score is invalid "
};
System.Console.WriteLine($"Your averege score is : {averageScore} and you are {scoreLevel} user of English");

System.Console.Write("Do you want to continue :Yes/No:");
isContinued=Console.ReadLine();
} while (isContinued.ToLower()=="yes");





