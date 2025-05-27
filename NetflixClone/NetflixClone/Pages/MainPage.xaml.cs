﻿using NetflixClone.Services;
using NetflixClone.ViewModels;

namespace NetflixClone.Pages;

public partial class MainPage : ContentPage
{

    private readonly HomeViewModel _homeViewModel;


    public MainPage(HomeViewModel homeViewModel)
    {
        InitializeComponent();
        _homeViewModel = homeViewModel;
        BindingContext = _homeViewModel;
    }

    protected async override  void OnAppearing()
    {
        base.OnAppearing();
        await _homeViewModel.InitializeAsync();
    }

}
