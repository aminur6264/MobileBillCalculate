// See https://aka.ms/new-console-template for more information




Console.Write("Start Time: ");
var callStart = Convert.ToDateTime(Console.ReadLine());
//Console.Write("End Time: ");
var callEnd = Convert.ToDateTime(Console.ReadLine());
//var callEnd = Convert.ToDateTime("2019-08-31 10:00:39 pm");

string  peekTimeStart = "9.00.00 am";
string  peekTimeEnd = "10.59.59 pm";


int pulseCount = 0;
bool isOverlap = false;
while (callEnd > callStart)
{
    pulseCount++;
    
    DateTime dtPeekcStart = Convert.ToDateTime(callStart.ToString("yyyy-MM-dd ") + peekTimeStart);
    DateTime dtPeekcEnd = Convert.ToDateTime(callStart.ToString("yyyy-MM-dd ") + peekTimeEnd);

    callStart = callStart.AddSeconds(20);
    if (callStart > dtPeekcStart || callStart.AddSeconds(-20)> dtPeekcStart)
    {
        isOverlap = true;
    }
}
decimal totalCost = 0;
if (isOverlap)
    totalCost = pulseCount * 0.3M;
else
    totalCost = pulseCount * 0.2M;
Console.WriteLine(totalCost+ " taka");