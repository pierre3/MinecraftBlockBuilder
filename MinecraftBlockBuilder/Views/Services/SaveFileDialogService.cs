﻿using Microsoft.Win32;
using MinecraftBlockBuilder.Services;
using MinecraftBlockBuilder.ViewModels;
using System;
using System.Windows;

namespace MinecraftBlockBuilder.Views
{
    public class SaveFileDialogService : IDialogService
    {
        public Type VmType { get; } = typeof(SaveFileDialogViewModel);
        private readonly Window owner;
        public SaveFileDialogService(Window owner)
        {

            this.owner = owner;
        }

        public bool? ShowDialog(IDialogViewModel vm)
        {
            var dialogViewModel = (SaveFileDialogViewModel)vm;
            var dialog = new SaveFileDialog()
            {
                FileName = dialogViewModel.FileName,
                InitialDirectory = dialogViewModel.InitialDirectory,
                CheckPathExists = true,
                Filter = dialogViewModel.Filter
            };
            var ret = dialog.ShowDialog(owner);
            dialogViewModel.FileName = dialog.FileName;
            return ret;
        }
    }
}
