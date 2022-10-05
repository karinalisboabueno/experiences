#Projeto Elaborado por Karina Bueno em 25/03/2022
##############Simulador de lançamento de dados##########################

#import das Bibliotecas a serem utilizadas
import random
import os

from random import randint

#gerar numero inteiro aleatorio entre 1 e 6
random.randint(1,6)



bola = "\u2022"
barraCima = "\u2581"
barraEsquerda = "\u258F"
barraDireita ="\u2595"
barraBaixo = "\u2594"

top = barraCima+barraCima+barraCima+barraCima+barraCima+barraCima+barraCima+barraCima+barraCima+"\n"
middle = barraEsquerda+"\t"+barraDireita+"\n"
bottom = barraBaixo+barraBaixo+barraBaixo+barraBaixo+barraBaixo+barraBaixo+barraBaixo+barraBaixo+barraBaixo

#Dicionario de dados - Mapa 
dado = {
    1: top + middle+barraEsquerda+"   "+bola+"\t"+barraDireita+"\n"+middle + bottom,
    2: top + barraEsquerda+bola+"\t"+barraDireita+"\n"+middle+barraEsquerda+"      "+bola+barraDireita+"\n"+bottom,
    3: top + barraEsquerda+bola+"\t"+barraDireita+"\n"+barraEsquerda+"   "+bola+"   "+barraDireita+"\n"+barraEsquerda+"      "+bola+barraDireita+"\n"+bottom,
    4: top + barraEsquerda+bola+"     "+bola+barraDireita+"\n"+middle+barraEsquerda+bola+"     "+bola+barraDireita+"\n"+bottom,
    5: top + barraEsquerda+bola+"     "+bola+barraDireita+"\n"+barraEsquerda+"   "+bola+"   "+barraDireita+"\n"+barraEsquerda+bola+"     "+bola+barraDireita+"\n"+bottom,
    6: top + barraEsquerda+bola+"     "+bola+barraDireita+"\n"+barraEsquerda+bola+"     "+bola+barraDireita+"\n"+barraEsquerda+bola+"     "+bola+barraDireita+"\n"+bottom
}


#Declaração da variavel bollean
repeat_rolling = True

#Enquanto for verdade executa o randint e mostra o valor, pergunta se quer jogar novamente.
while repeat_rolling:
    valor = randint(1,6)
    print("Você rolou o seguinte número usando os dados:\n"+dado.get(valor)) 
    print("Deseja jogar os dados novamente?")
    repeat_rolling = ("s" or "sim") in input().lower()    
    os.system('cls')

