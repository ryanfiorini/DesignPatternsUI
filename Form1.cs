using DesignPatternsUI.Creational.Builder;
using DesignPatternsUI.Creational.Creational;
using DesignPatternsUI.Creational.FactoryMethod;
using DesignPatternsUI.Creational.Prototype;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DesignPatternsUI.Creational.Prototype;
using DesignPatternsUI2.Creational.Singleton;
using DesignPatternsUI2.Structural.Adapter;
using DesignPatternsUI2.Structural.Bridge;
using DesignPatternsUI2.Structural.Composite;
using DesignPatternsUI.Structural.Decorator;
using System.Diagnostics;

namespace DesignPatternsUI2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAbstractFactory_Click(object sender, EventArgs e)
        {
            // ------------------------------------------------------------------------
            // Abstract Factory Pattern
            // https://dofactory.com/net/abstract-factory-design-pattern 
            // Frequency of use: 5 High

            txtOutput.Text = "";

            // Abstract factory #1
            AbstractFactory factory1 = new ConcreteFactory1();
            Client client1 = new Client(factory1);
            txtOutput.Text += client1.Run() + Environment.NewLine;

            // Abstract factory #2
            AbstractFactory factory2 = new ConcreteFactory2();
            Client client2 = new Client(factory2);
            txtOutput.Text += client2.Run() + Environment.NewLine;

        }

        private void btnBuilder_Click(object sender, EventArgs e)
        {
            // ------------------------------------------------------------------------
            // Builder Pattern
            // https://dofactory.com/net/builder-design-pattern
            // Frequency of use: 3 - Medium low

            txtOutput.Text = "";

            VehicleBuilder builder;

            // Create shop with vehicle builders
            Shop shop = new Shop();

            // Construct and display vehicles
            builder = new ScooterBuilder();
            shop.Construct(builder);
            txtOutput.Text += builder.Vehicle.Show();

            builder = new CarBuilder();
            shop.Construct(builder);
            txtOutput.Text += builder.Vehicle.Show();

            builder = new MotorCycleBuilder();
            shop.Construct(builder);
            txtOutput.Text += builder.Vehicle.Show();

        }

        private void btnFactoryMethod_Click(object sender, EventArgs e)
        {
            // ------------------------------------------------------------------------
            // Factory Method
            // https://dofactory.com/net/factory-method-design-pattern 
            // Frequency of use: 5 - High

            txtOutput.Text = "";

            // Note: constructors call Factory Method
            Document[] documents = new Document[2];

            documents[0] = new Resume();
            documents[1] = new Report();

            // Display document pages

            foreach (Document document in documents)
            {
                txtOutput.Text += (document.GetType().Name + "--");
                foreach (Page page in document.Pages)
                {
                    txtOutput.Text += (" " + page.GetType().Name);
                }
            }

        }

        private void btnPrototype_Click(object sender, EventArgs e)
        {
            // ------------------------------------------------------------------------
            // Prototype Pattern
            // https://dofactory.com/net/prototype-design-pattern
            // Frequency of use: 3 - Medium

            txtOutput.Text = "";

            ColorManager colormanager = new ColorManager();

            // Initialize with standard colors

            colormanager["red"] = new Color(255, 0, 0);
            colormanager["green"] = new Color(0, 255, 0);
            colormanager["blue"] = new Color(0, 0, 255);

            // User adds personalized colors

            colormanager["angry"] = new Color(255, 54, 0);
            colormanager["peace"] = new Color(128, 211, 128);
            colormanager["flame"] = new Color(211, 34, 20);

            // User clones selected colors

            Color color1 = colormanager["red"].Clone() as Color;
            txtOutput.Text += color1.ToString() + Environment.NewLine;

            Color color2 = colormanager["peace"].Clone() as Color;
            txtOutput.Text += color1.ToString() + Environment.NewLine;

            Color color3 = colormanager["flame"].Clone() as Color;
            txtOutput.Text += color1.ToString() + Environment.NewLine;

            txtOutput.Text += "Clone Complete";

        }

        private void btnSingleton_Click(object sender, EventArgs e)
        {
            // ------------------------------------------------------------------------
            // Singleton Pattern
            // https://dofactory.com/net/singleton-design-pattern
            // Frequency of use: 4 - Medium

            txtOutput.Text = "";

            LoadBalancer b1 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b2 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b3 = LoadBalancer.GetLoadBalancer();
            LoadBalancer b4 = LoadBalancer.GetLoadBalancer();

            if (b1 == b2 && b2 == b3 && b3 == b4)
            {
                txtOutput.Text += "Same Instance" + Environment.NewLine;
            }

            LoadBalancer balancer = LoadBalancer.GetLoadBalancer();
            
            for (int i = 0; i < 15; i++)
            {
                string server = balancer.Server;
                txtOutput.Text += "Dispatch Request to: " + server + Environment.NewLine;
            }
        }

        private void btnAdapter_Click(object sender, EventArgs e)
        {
            // ------------------------------------------------------------------------
            // Adapter Pattern
            // https://dofactory.com/net/adapter-design-pattern
            // Frequency of use: 4 - Medium

            txtOutput.Text = "";

            // Non-adapted chemical compound

            Compound unknown = new Compound("Unknown");
            txtOutput.Text += unknown.Display() + Environment.NewLine;

            // Adapted chemical compounds

            Compound water = new RichCompound("Water");
            txtOutput.Text += water.Display() + Environment.NewLine;

            Compound benzene = new RichCompound("Benzene");
            txtOutput.Text += benzene.Display() + Environment.NewLine;

            Compound ethanol = new RichCompound("Ethanol");
            txtOutput.Text += ethanol.Display() + Environment.NewLine;

        }

        private void btnBridge_Click(object sender, EventArgs e)
        {
            // ------------------------------------------------------------------------
            // Bridge Pattern
            // https://dofactory.com/net/bridge-design-pattern
            // Frequency of use: 3 - Medium

            txtOutput.Text = "";

            // Create RefinedAbstraction
            Customer customer = new Customer("Chicago");

            // Set ConcreteImplementor
            customer.Data = new CustomersData();

            // Exercise the bridge
            customer.Show();
            customer.Next();
            customer.Show();
            customer.Next();
            customer.Show();
            customer.Add("Henry Velasquez");

            customer.ShowAll();

        }

        private void btnComposite_Click(object sender, EventArgs e)
        {
            // Create a tree structure 
            CompositeElement root = new CompositeElement("Picture");
            root.Add(new PrimitiveElement("Red Line"));
            root.Add(new PrimitiveElement("Blue Circle"));
            root.Add(new PrimitiveElement("Green Box"));

            // Create a branch
            CompositeElement comp = new CompositeElement("Two Circles");
            comp.Add(new PrimitiveElement("Black Circle"));
            comp.Add(new PrimitiveElement("White Circle"));
            root.Add(comp);

            // Add and remove a PrimitiveElement
            PrimitiveElement pe = new PrimitiveElement("Yellow Line");
            root.Add(pe);
            root.Remove(pe);

            // Recursively display nodes
            root.Display(1);

        }

        private void btnDecorator_Click(object sender, EventArgs e)
        {
            // Create book

            Book book = new Book("Worley", "Inside ASP.NET", 10);
            book.Display();

            // Create video

            Video video = new Video("Spielberg", "Jaws", 23, 92);
            video.Display();

            // Make video borrowable, then borrow and display

            Debug.WriteLine("\nMaking video borrowable:");

            Borrowable borrowvideo = new Borrowable(video);
            borrowvideo.BorrowItem("Customer #1");
            borrowvideo.BorrowItem("Customer #2");

            borrowvideo.Display();
        }
    }
}
