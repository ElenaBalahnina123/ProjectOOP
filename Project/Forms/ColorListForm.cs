﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class ColorListForm : Form
    {
        private readonly ProgramState programState;
        private readonly AppDbContext db;

        public ColorListForm(ProgramState state, AppDbContext dbContext)
        {
            programState = state;
            db = dbContext;
            InitializeComponent();
            LoadColors();
        }

        private async void LoadColors()
        {
            var list = await Task.Run(() => db.Colors.ToList());
            colors_list.DataSource = list;
        }

        private async void btn_add_new_Click(object sender, EventArgs e)
        {
            var color = await ColorEditor.EditColorAsync();

            await db.AddAsync(color);
            LoadColors();
        }
    }
}
