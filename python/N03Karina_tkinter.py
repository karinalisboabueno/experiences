#Projeto Elaborado por Karina Bueno em 25/03/2022
##############Simulador de lançamento de dados##########################

#import das Bibliotecas a serem utilizadas
from tkinter import *
import random


root= Tk() #Define a janela tkinter 
root.geometry("700x450") #tamanho da janela
root.title("Jogue o dado da Karina") #titulo da janela
root.iconbitmap('icon/dado.ico') #colocar icone na janela
root.configure(background='pink')

label=Label(root,text="", font=("times",260))

def roll():
    dado=['\u2680','\u2681','\u2682','\u2683','\u2684','\u2685','\u2764']
    label.configure(text=f'{random.choice(dado)}', foreground='purple', background='pink')
    label.pack()


button=Button(root, text= "jogue o dado", width=40, height=5, font=10, bg='purple', foreground='white', bd=2, command=roll )
button.pack(padx=10,pady=10)




root.mainloop()
