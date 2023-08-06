string name = "Ewa";
char sex = 'f';  // f - female  /   m -male
int age = 17;
if (sex == 'f' && age < 30)
{
    Console.WriteLine("Kobieta poniżej 30 lat");
}
else if (name == "Ewa" && age == 33 && sex == 'f')
{
    Console.WriteLine("Ewa, lat 33");
}
else if (age < 18 && sex == 'm')
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Poza kryteriami");
}