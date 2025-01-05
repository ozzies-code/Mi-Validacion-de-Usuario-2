# Mi Validacion de Usuario 2
 Este proyecto aplica las mascaras de entrada en la validacion de usuarios a un  sistema

# Descripcion

 Este proyecto consiste en una aplicacion que emplea 
 mascaras de entrada en un proceso de validacion de 
 usuarios para asegurarse que los datos ingresados
 se ingresen en el formato de la mascara especificada
 a traves del objetos MaskedTextbox. Cuando se ingresa
 correctamente se le da la bienvenida al usuario en el 
 sistema.
 
 # Actualizacion: 04/01/2025
 # Hora: 20:34

Detalles técnicos del proyecto:
Idioma: Visual Basic.NET
Versión del framework: 4.7.2

# My User Validation 2
This project applies input masks in user validation to a system

# Description

This project consists of an application that uses
input masks in a user validation process to ensure that the data entered
is entered in the format of the specified mask
through the MaskedTextbox object. When entered correctly, the user is welcomed into the
system.

# Update: 04/01/2025
# Time: 20:34

Technical details of the project:
Language: Visual Basic.NET
Framework version: 4.7.2

![imagen](https://github.com/user-attachments/assets/32c443f5-8914-40e8-8df3-c2c28ec54b5b)

Code of the Project:

Public Class Form1
    
    Private Sub btnRegistro_Click(sender As Object, e As EventArgs) Handles btnRegistro.Click
        'Mascaras de Entrada 
        If MaskedTextBox1.Text = "555-55-1212" _
        And MaskedTextBox2.Text = "54321" Then
            MsgBox("¡Bienvenido al sistema!")
        Else
            MsgBox("Número irreconocible")
        End If
    End Sub
End Class
