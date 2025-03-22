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
System.Console.WriteLine($"Your IELTS score:{averageScore}");





