﻿namespace milhao;

public partial class MainPage : ContentPage
{
 public MainPage()
 {
	InitializeComponent();
 }
 private void Começar(object sender, EventArgs e)
 {
	Application.Current.MainPage = new JogoPage();
 }
}

