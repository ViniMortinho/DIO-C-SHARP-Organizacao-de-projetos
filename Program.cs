﻿using ExemplosFundamentos.models;
//Trabalalhando com Do While)
int soma =0 ,numero = 0;


do{
    Console.WriteLine("Digite um numero(0 para parar)");
    numero = Convert.ToInt32(Console.ReadLine());

} while (numero !=0);
Console.WriteLine($"Total da soma dos numeros digitados é :{soma}");















// Trabalhando com while
/* int numero = 5;
int contador = 0; 

while(contador <= 10)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
    contador++;

    if(contador ==5)
    {
        break;
    }
} */

// Introdução ao FOR
/* 
int numero = 5;

for(int contador = 0; contador <= 10; contador++)
{
    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
}
*/
