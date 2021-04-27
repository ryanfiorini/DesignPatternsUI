
namespace DesignPatternsUI2
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel3 = new System.Windows.Forms.Panel();
            this.button18 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSingleton = new System.Windows.Forms.Button();
            this.btnPrototype = new System.Windows.Forms.Button();
            this.btnFactoryMethod = new System.Windows.Forms.Button();
            this.btnBuilder = new System.Windows.Forms.Button();
            this.btnAbstractFactory = new System.Windows.Forms.Button();
            this.txtOutput = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.bntProxy = new System.Windows.Forms.Button();
            this.btnFlyweight = new System.Windows.Forms.Button();
            this.bntFacade = new System.Windows.Forms.Button();
            this.btnDecorator = new System.Windows.Forms.Button();
            this.btnComposite = new System.Windows.Forms.Button();
            this.btnBridge = new System.Windows.Forms.Button();
            this.btnAdapter = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.button18);
            this.panel3.Controls.Add(this.button17);
            this.panel3.Controls.Add(this.button16);
            this.panel3.Controls.Add(this.button15);
            this.panel3.Controls.Add(this.button14);
            this.panel3.Controls.Add(this.button13);
            this.panel3.Controls.Add(this.button12);
            this.panel3.Controls.Add(this.button11);
            this.panel3.Controls.Add(this.button10);
            this.panel3.Controls.Add(this.button9);
            this.panel3.Controls.Add(this.button8);
            this.panel3.Location = new System.Drawing.Point(844, 67);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(339, 571);
            this.panel3.TabIndex = 8;
            // 
            // button18
            // 
            this.button18.Location = new System.Drawing.Point(11, 472);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(316, 38);
            this.button18.TabIndex = 13;
            this.button18.Text = "Visitor";
            this.button18.UseVisualStyleBackColor = true;
            // 
            // button17
            // 
            this.button17.Location = new System.Drawing.Point(11, 427);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(316, 38);
            this.button17.TabIndex = 12;
            this.button17.Text = "Template Method";
            this.button17.UseVisualStyleBackColor = true;
            // 
            // button16
            // 
            this.button16.Location = new System.Drawing.Point(11, 383);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(316, 38);
            this.button16.TabIndex = 11;
            this.button16.Text = "Strategy";
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(10, 339);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(316, 38);
            this.button15.TabIndex = 10;
            this.button15.Text = "State";
            this.button15.UseVisualStyleBackColor = true;
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(9, 291);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(316, 38);
            this.button14.TabIndex = 9;
            this.button14.Text = "Observer";
            this.button14.UseVisualStyleBackColor = true;
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(8, 247);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(316, 38);
            this.button13.TabIndex = 8;
            this.button13.Text = "Memento";
            this.button13.UseVisualStyleBackColor = true;
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(8, 203);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(316, 38);
            this.button12.TabIndex = 7;
            this.button12.Text = "Mediator";
            this.button12.UseVisualStyleBackColor = true;
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(7, 157);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(316, 38);
            this.button11.TabIndex = 6;
            this.button11.Text = "Iterator";
            this.button11.UseVisualStyleBackColor = true;
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(7, 109);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(316, 38);
            this.button10.TabIndex = 5;
            this.button10.Text = "Interpreter";
            this.button10.UseVisualStyleBackColor = true;
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(7, 62);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(316, 38);
            this.button9.TabIndex = 4;
            this.button9.Text = "Command";
            this.button9.UseVisualStyleBackColor = true;
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(7, 16);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(316, 38);
            this.button8.TabIndex = 3;
            this.button8.Text = "Chain of Responsibility";
            this.button8.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.btnSingleton);
            this.panel1.Controls.Add(this.btnPrototype);
            this.panel1.Controls.Add(this.btnFactoryMethod);
            this.panel1.Controls.Add(this.btnBuilder);
            this.panel1.Controls.Add(this.btnAbstractFactory);
            this.panel1.Location = new System.Drawing.Point(53, 67);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(339, 424);
            this.panel1.TabIndex = 6;
            // 
            // btnSingleton
            // 
            this.btnSingleton.Location = new System.Drawing.Point(12, 191);
            this.btnSingleton.Name = "btnSingleton";
            this.btnSingleton.Size = new System.Drawing.Size(316, 38);
            this.btnSingleton.TabIndex = 5;
            this.btnSingleton.Text = "Singleton";
            this.btnSingleton.UseVisualStyleBackColor = true;
            this.btnSingleton.Click += new System.EventHandler(this.btnSingleton_Click);
            // 
            // btnPrototype
            // 
            this.btnPrototype.Location = new System.Drawing.Point(12, 147);
            this.btnPrototype.Name = "btnPrototype";
            this.btnPrototype.Size = new System.Drawing.Size(316, 38);
            this.btnPrototype.TabIndex = 4;
            this.btnPrototype.Text = "Prototype";
            this.btnPrototype.UseVisualStyleBackColor = true;
            this.btnPrototype.Click += new System.EventHandler(this.btnPrototype_Click);
            // 
            // btnFactoryMethod
            // 
            this.btnFactoryMethod.Location = new System.Drawing.Point(12, 103);
            this.btnFactoryMethod.Name = "btnFactoryMethod";
            this.btnFactoryMethod.Size = new System.Drawing.Size(316, 38);
            this.btnFactoryMethod.TabIndex = 3;
            this.btnFactoryMethod.Text = "Factory Method";
            this.btnFactoryMethod.UseVisualStyleBackColor = true;
            this.btnFactoryMethod.Click += new System.EventHandler(this.btnFactoryMethod_Click);
            // 
            // btnBuilder
            // 
            this.btnBuilder.Location = new System.Drawing.Point(12, 59);
            this.btnBuilder.Name = "btnBuilder";
            this.btnBuilder.Size = new System.Drawing.Size(316, 38);
            this.btnBuilder.TabIndex = 2;
            this.btnBuilder.Text = "Builder";
            this.btnBuilder.UseVisualStyleBackColor = true;
            this.btnBuilder.Click += new System.EventHandler(this.btnBuilder_Click);
            // 
            // btnAbstractFactory
            // 
            this.btnAbstractFactory.Location = new System.Drawing.Point(12, 15);
            this.btnAbstractFactory.Name = "btnAbstractFactory";
            this.btnAbstractFactory.Size = new System.Drawing.Size(316, 38);
            this.btnAbstractFactory.TabIndex = 1;
            this.btnAbstractFactory.Text = "Abstract Factory";
            this.btnAbstractFactory.UseVisualStyleBackColor = true;
            this.btnAbstractFactory.Click += new System.EventHandler(this.btnAbstractFactory_Click);
            // 
            // txtOutput
            // 
            this.txtOutput.Location = new System.Drawing.Point(53, 511);
            this.txtOutput.Multiline = true;
            this.txtOutput.Name = "txtOutput";
            this.txtOutput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtOutput.Size = new System.Drawing.Size(734, 209);
            this.txtOutput.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(924, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Behavioral Patterns";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(528, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(128, 20);
            this.label2.TabIndex = 11;
            this.label2.Text = "Structural Patterns";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.bntProxy);
            this.panel2.Controls.Add(this.btnFlyweight);
            this.panel2.Controls.Add(this.bntFacade);
            this.panel2.Controls.Add(this.btnDecorator);
            this.panel2.Controls.Add(this.btnComposite);
            this.panel2.Controls.Add(this.btnBridge);
            this.panel2.Controls.Add(this.btnAdapter);
            this.panel2.Location = new System.Drawing.Point(448, 67);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(339, 424);
            this.panel2.TabIndex = 9;
            // 
            // bntProxy
            // 
            this.bntProxy.Location = new System.Drawing.Point(12, 291);
            this.bntProxy.Name = "bntProxy";
            this.bntProxy.Size = new System.Drawing.Size(316, 38);
            this.bntProxy.TabIndex = 8;
            this.bntProxy.Text = "Proxy";
            this.bntProxy.UseVisualStyleBackColor = true;
            // 
            // btnFlyweight
            // 
            this.btnFlyweight.Location = new System.Drawing.Point(12, 243);
            this.btnFlyweight.Name = "btnFlyweight";
            this.btnFlyweight.Size = new System.Drawing.Size(316, 38);
            this.btnFlyweight.TabIndex = 7;
            this.btnFlyweight.Text = "Flyweight";
            this.btnFlyweight.UseVisualStyleBackColor = true;
            // 
            // bntFacade
            // 
            this.bntFacade.Location = new System.Drawing.Point(11, 197);
            this.bntFacade.Name = "bntFacade";
            this.bntFacade.Size = new System.Drawing.Size(316, 38);
            this.bntFacade.TabIndex = 6;
            this.bntFacade.Text = "Facade";
            this.bntFacade.UseVisualStyleBackColor = true;
            // 
            // btnDecorator
            // 
            this.btnDecorator.Location = new System.Drawing.Point(11, 152);
            this.btnDecorator.Name = "btnDecorator";
            this.btnDecorator.Size = new System.Drawing.Size(316, 38);
            this.btnDecorator.TabIndex = 5;
            this.btnDecorator.Text = "Decorator";
            this.btnDecorator.UseVisualStyleBackColor = true;
            this.btnDecorator.Click += new System.EventHandler(this.btnDecorator_Click);
            // 
            // btnComposite
            // 
            this.btnComposite.Location = new System.Drawing.Point(10, 107);
            this.btnComposite.Name = "btnComposite";
            this.btnComposite.Size = new System.Drawing.Size(316, 38);
            this.btnComposite.TabIndex = 4;
            this.btnComposite.Text = "Composite";
            this.btnComposite.UseVisualStyleBackColor = true;
            this.btnComposite.Click += new System.EventHandler(this.btnComposite_Click);
            // 
            // btnBridge
            // 
            this.btnBridge.Location = new System.Drawing.Point(11, 60);
            this.btnBridge.Name = "btnBridge";
            this.btnBridge.Size = new System.Drawing.Size(316, 38);
            this.btnBridge.TabIndex = 3;
            this.btnBridge.Text = "Bridge";
            this.btnBridge.UseVisualStyleBackColor = true;
            this.btnBridge.Click += new System.EventHandler(this.btnBridge_Click);
            // 
            // btnAdapter
            // 
            this.btnAdapter.Location = new System.Drawing.Point(11, 16);
            this.btnAdapter.Name = "btnAdapter";
            this.btnAdapter.Size = new System.Drawing.Size(316, 38);
            this.btnAdapter.TabIndex = 2;
            this.btnAdapter.Text = "Adapter";
            this.btnAdapter.UseVisualStyleBackColor = true;
            this.btnAdapter.Click += new System.EventHandler(this.btnAdapter_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(133, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Creational Patterns";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1276, 732);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtOutput);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSingleton;
        private System.Windows.Forms.Button btnPrototype;
        private System.Windows.Forms.Button btnFactoryMethod;
        private System.Windows.Forms.Button btnBuilder;
        private System.Windows.Forms.Button btnAbstractFactory;
        private System.Windows.Forms.TextBox txtOutput;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button bntProxy;
        private System.Windows.Forms.Button btnFlyweight;
        private System.Windows.Forms.Button bntFacade;
        private System.Windows.Forms.Button btnDecorator;
        private System.Windows.Forms.Button btnComposite;
        private System.Windows.Forms.Button btnBridge;
        private System.Windows.Forms.Button btnAdapter;
    }
}

