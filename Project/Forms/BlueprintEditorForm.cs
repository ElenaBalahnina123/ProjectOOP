﻿using ProjectOop.Entities;
using System;
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
    public partial class BlueprintEditorForm : Form
    {
        public BlueprintEditorForm()
        {
            InitializeComponent();
        }

        public BlueprintEditorForm SetProduct(Product product)
        {
            name_sketch.Text = product.Sketch.Name;
            return this;
        }

        public async Task<Blueprint?> GetBlueprintAsync()
        {
            throw new Exception("not implemented");
        }
    }
}