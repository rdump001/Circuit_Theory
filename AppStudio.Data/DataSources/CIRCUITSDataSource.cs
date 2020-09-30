using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class CIRCUITSDataSource : DataSourceBase<CIRCUITSSchema>
    {
        protected override string CacheKey
        {
            get { return "CIRCUITSDataSource"; }
        }

        public override bool HasStaticData
        {
            get { return true; }
        }

        private readonly IEnumerable<CIRCUITSSchema> _data = new CIRCUITSSchema[]
		{
            new CIRCUITSSchema
            {
                Title = "CIRCUIT ELEMENTS ",
                Subtitle = "Idealized electrical components ",
                ImageUrl = "/Assets/DataImages/Circuit-board-with-chips-wallpaper_5454.jpg",
                Description = "Idealized electrical components, such as resistors, capacitors, and inductors, us" +
    "ed in the analysis of electrical networks. Any electrical network can be analyse" +
    "d as multiple, interconnected electrical elements in a schematic diagram or circ" +
    "uit diagram, each of which affects the voltage in the network or current through" +
    " the network. These ideal electrical elements represent real, physical electrica" +
    "l or electronic components but they do not exist physically and they are assumed" +
    " to have ideal properties according to a lumped element model, while components " +
    "are objects with less than ideal properties, a degree of uncertainty in their va" +
    "lues and some degree of nonlinearity, each of which may require a combination of" +
    " multiple electrical elements in order to approximate its function.\n\nCircuit ana" +
    "lysis using electric elements is useful for understanding many practical electri" +
    "cal networks using components. By analyzing the way a network is affected by its" +
    " individual elements it is possible to estimate how a real network will behave.\n" +
    "One-port elements : \nOnly nine types of element (memristor not included), five p" +
    "assive and four active, are required to model any electrical component or circui" +
    "t.[citation needed] Each element is defined by a relation between the state vari" +
    "ables of the network: current, I; voltage, V, charge, Q; and magnetic flux, \\Phi" +
    ".\n passive elements: Resistance\n[ dV = R\\,dI ].\nCapacitance\n[ dQ = C\\,dV ].\nIndu" +
    "ctance\n[d\\Phi = L\\,dI].\nabstract active elements: \nVoltage-controlled voltage so" +
    "urce (VCVS)\nVoltage-controlled current source (VCCS)\nCurrent-controlled voltage " +
    "source (CCVS) \nCurrent-controlled current source (CCCS) ",
            },
            new CIRCUITSSchema
            {
                Title = "Kirchhoff\'s Laws",
                Subtitle = "Laws for Circuit Analysis",
                ImageUrl = "/Assets/DataImages/kirchoff_junction_rule.jpg",
                Description = "Kirchhoff\'s current law (KCL) :\nThis law is also called Kirchhoff\'s first law, Ki" +
    "rchhoff\'s point rule, or Kirchhoff\'s junction rule (or nodal rule).\n\nThe princip" +
    "le of conservation of electric charge implies that:\n\nAt any node (junction) in a" +
    "n electrical circuit, the sum of currents flowing into that node is equal to the" +
    " sum of currents flowing out of that node, or:\nThe algebraic sum of currents in " +
    "a network of conductors meeting at a point is zero.\nRecalling that current is a " +
    "signed (positive or negative) quantity reflecting direction towards or away from" +
    " a node, this principle can be stated as:\n\n\\sum_{k=1}^n {I}_k = 0\nn is the total" +
    " number of branches with currents flowing towards or away from the node.\n\nThis f" +
    "ormula is valid for complex currents:\n\n\\sum_{k=1}^n \\tilde{I}_k = 0\nThe law is b" +
    "ased on the conservation of charge whereby the charge (measured in coulombs) is " +
    "the product of the current (in amperes) and the time (in seconds).\nKirchhoff\'s v" +
    "oltage law (KVL) :\nThis law is also called Kirchhoff\'s second law, Kirchhoff\'s l" +
    "oop (or mesh) rule, and Kirchhoff\'s second rule.\n\nThe principle of conservation " +
    "of energy implies that\n\nThe directed sum of the electrical potential differences" +
    " (voltage) around any closed network is zero, or:\nMore simply, the sum of the em" +
    "fs in any closed loop is equivalent to the sum of the potential drops in that lo" +
    "op, or:\nThe algebraic sum of the products of the resistances of the conductors a" +
    "nd the currents in them in a closed loop is equal to the total emf available in " +
    "that loop.\nSimilarly to KCL, it can be stated as:\n\n\\sum_{k=1}^n V_k = 0\nHere, n " +
    "is the total number of voltages measured. The voltages may also be complex:\n\n\\su" +
    "m_{k=1}^n \\tilde{V}_k = 0\nThis law is based on the conservation of energy whereb" +
    "y voltage is defined as the energy per unit charge. The total amount of energy g" +
    "ained per unit charge must equal the amount of energy lost per unit charge, as e" +
    "nergy and charge are both conserved.",
            },
            new CIRCUITSSchema
            {
                Title = "Mesh analysis",
                Subtitle = "Mesh Current Method",
                ImageUrl = "/Assets/DataImages/519b958acded896906.jpg",
                Description = "Mesh analysis (or the mesh current method) is a method that is used to solve plan" +
    "ar circuits for the currents (and indirectly the voltages) at any place in the c" +
    "ircuit. Planar circuits are circuits that can be drawn on a plane surface with n" +
    "o wires crossing each other. A more general technique, called loop analysis (wit" +
    "h the corresponding network variables called loop currents) can be applied to an" +
    "y circuit, planar or not. Mesh analysis and loop analysis both make use of Kirch" +
    "hoff’s voltage law to arrive at a set of equations guaranteed to be solvable if " +
    "the circuit has a solution. Mesh analysis is usually easier to use when the circ" +
    "uit is planar, compared to loop analysis.\n\nMesh analysis works by arbitrarily as" +
    "signing mesh currents in the essential meshes (also referred to as independent m" +
    "eshes). An essential mesh is a loop in the circuit that does not contain any oth" +
    "er loop.\n\nA mesh current is a current that loops around the essential mesh and t" +
    "he equations are set solved in terms of them. A mesh current may not correspond " +
    "to any physically flowing current, but the physical currents are easily found fr" +
    "om them. It is usual practice to have all the mesh currents loop in the same dir" +
    "ection. This helps prevent errors when writing out the equations. The convention" +
    " is to have all the mesh currents looping in a clockwise direction.\n\nSolving for" +
    " mesh currents instead of directly applying Kirchhoff\'s current law and Kirchhof" +
    "f\'s voltage law can greatly reduce the amount of calculation required. This is b" +
    "ecause there are fewer mesh currents than there are physical branch currents.",
            },
            new CIRCUITSSchema
            {
                Title = "Nodal Analysis",
                Subtitle = " Branch Current Method",
                ImageUrl = "/Assets/DataImages/images.jpg",
                Description = "\nNodal analysis is possible when all the circuit elements\' branch constitutive re" +
    "lations have an admittance representation. Nodal analysis produces a compact set" +
    " of equations for the network, which can be solved by hand if small, or can be q" +
    "uickly solved using linear algebra by computer. Because of the compact system of" +
    " equations, many circuit simulation programs (e.g. SPICE) use nodal analysis as " +
    "a basis. When elements do not have admittance representations, a more general ex" +
    "tension of nodal analysis, modified nodal analysis, can be used.\nMethod : \n\nNote" +
    " all connected wire segments in the circuit. These are the nodes of nodal analys" +
    "is.\nSelect one node as the ground reference. The choice does not affect the resu" +
    "lt and is just a matter of convention. Choosing the node with the most connectio" +
    "ns can simplify the analysis.\nAssign a variable for each node whose voltage is u" +
    "nknown. If the voltage is already known, it is not necessary to assign a variabl" +
    "e.\nFor each unknown voltage, form an equation based on Kirchhoff\'s current law. " +
    "Basically, add together all currents leaving from the node and mark the sum equa" +
    "l to zero. Finding the current between two nodes is nothing more than \"the node " +
    "you\'re on, minus the node you\'re going to, divided by the resistance between the" +
    " two nodes.\"\nIf there are voltage sources between two unknown voltages, join the" +
    " two nodes as a supernode. The currents of the two nodes are combined in a singl" +
    "e equation, and a new equation for the voltages is formed.\nSolve the system of s" +
    "imultaneous equations for each unknown voltage.",
            },
            new CIRCUITSSchema
            {
                Title = "Series Circuits ",
                Subtitle = "A circuit composed solely of components connected in series is known as a series " +
    "circuit",
                ImageUrl = "/Assets/DataImages/light_p25a.jpg",
                Description = "Series circuits are sometimes called current-coupled or daisy chain-coupled. The " +
    "current in a series circuit goes through every component in the circuit. Therefo" +
    "re, all of the components in a series connection carry the same current. There i" +
    "s only one path in a series circuit in which the current can flow.\n\nA series cir" +
    "cuit\'s main disadvantage or advantage, depending on its intended role in a produ" +
    "ct\'s overall design, is that because there is only one path in which its current" +
    " can flow, opening or breaking a series circuit at any point causes the entire c" +
    "ircuit to \"open\" or stop operating. For example, if even one of the light bulbs " +
    "in an older-style string of Christmas tree lights burns out or is removed, the e" +
    "ntire string becomes inoperable until the bulb is replaced.\nCurrent\nIn a series " +
    "circuit the current is the same for all elements.\nResistors :\nThe total resistan" +
    "ce of resistors in series is equal to the sum of their individual resistances:\nS" +
    "everal resistors, connected end to end, with the same amount of current through " +
    "each.\nElectrical conductance presents a reciprocal quantity to resistance. Total" +
    " conductance of a series circuits of pure resistors.\nInductors : \nInductors foll" +
    "ow the same law, in that the total inductance of non-coupled inductors in series" +
    " is equal to the sum of their individual inductances\n\nSeveral inductors, connect" +
    "ed end to end, with the same amount of current going through each.\nHowever, in s" +
    "ome situations it is difficult to prevent adjacent inductors from influencing ea" +
    "ch other, as the magnetic field of one device couples with the windings of its n" +
    "eighbours. \nCapacitors :\nCapacitors follow the same law using the reciprocals. T" +
    "he total capacitance of capacitors in series is equal to the reciprocal of the s" +
    "um of the reciprocals of their individual capacitances:\nseveral capacitors, conn" +
    "ected end to end, with the same amount of current going through each.",
            },
            new CIRCUITSSchema
            {
                Title = "Parallel Circuits ",
                Subtitle = " One connected completely in parallel is known as a parallel circuit.",
                ImageUrl = "/Assets/DataImages/light_p25b.jpg",
                Description = @"If two or more components are connected in parallel they have the same potential difference (voltage) across their ends. The potential differences across the components are the same in magnitude, and they also have identical polarities. The same voltage is applicable to all circuit components connected in parallel. The total current is the sum of the currents through the individual components, in accordance with Kirchhoff’s current law.
Voltage:
In a parallel circuit the voltage is the same for all elements.
Resistors
The current in each individual resistor is found by Ohm's law. Factoring out the voltage gives

To find the total resistance of all components, add the reciprocals of the resistances R_i of each component and take the reciprocal of the sum. Total resistance will always be less than the value of the smallest resistance:

Several resistors, side by side, both leads of each connected to the same wires.


The components divide the current according to their reciprocal resistances.

An old term for devices connected in parallel is multiple, such as a multiple connection for arc lamps. ",
            },
            new CIRCUITSSchema
            {
                Title = "Magnetic Circuits ",
                Subtitle = "consists of magnets ",
                ImageUrl = "/Assets/DataImages/torus.jpg",
                Description = @"A magnetic circuit is made up of one or more closed loop paths containing a magnetic flux. The flux is usually generated by permanent magnets or electromagnets and confined to the path by magnetic cores consisting of ferromagnetic materials like iron, although there may be air gaps or other materials in the path. Magnetic circuits are employed to efficiently channel magnetic fields in many devices such as electric motors, generators, transformers, relays, lifting electromagnets, SQUIDs, galvanometers, and magnetic recording heads.

The concept of a ""magnetic circuit"" exploits a one-to-one correspondence between the equations of the magnetic field in an unsaturated ferromagnetic material to that of an electrical circuit. Using this concept the magnetic fields of complex devices such as transformers can be quickly solved using the methods and techniques developed for electrical circuits.

Some examples of magnetic circuits are:

horseshoe magnet with iron keeper (low-reluctance circuit)
horseshoe magnet with no keeper (high-reluctance circuit)
electric motor (variable-reluctance circuit)",
            },
            new CIRCUITSSchema
            {
                Title = "Integrated circuit",
                Subtitle = "monolithic integrated circuits ",
                ImageUrl = "/Assets/DataImages/images__1_.jpg",
                Description = "An integrated circuit or monolithic integrated circuit (also referred to as an IC" +
    ", a chip, or a microchip) is a set of electronic circuits on one small plate (\"c" +
    "hip\") of semiconductor material, normally silicon. This can be made much smaller" +
    " than a discrete circuit made from independent components. ICs can be made very " +
    "compact, having up to several billion transistors and other electronic component" +
    "s in an area the size of a fingernail. The width of each conducting line in a ci" +
    "rcuit can be made smaller and smaller as the technology advances; in 2008 it dro" +
    "pped below 100 nanometer,and now it is tens of nanometers.\n\nICs were made possib" +
    "le by experimental discoveries showing that semiconductor devices could perform " +
    "the functions of vacuum tubes and by mid-20th-century technology advancements in" +
    " semiconductor device fabrication. The integration of large numbers of tiny tran" +
    "sistors into a small chip was an enormous improvement over the manual assembly o" +
    "f circuits using discrete electronic components. The integrated circuit\'s mass p" +
    "roduction capability, reliability, and building-block approach to circuit design" +
    " ensured the rapid adoption of standardized integrated circuits in place of desi" +
    "gns using discrete transistors.\n\nThere are two main advantages of ICs over discr" +
    "ete circuits: cost and performance. Cost is low because the chips, with all thei" +
    "r components, are printed as a unit by photolithography rather than being constr" +
    "ucted one transistor at a time. Furthermore, much less material is used to const" +
    "ruct a packaged IC die than to construct a discrete circuit. Performance is high" +
    " because the components switch quickly and consume little power (compared to the" +
    "ir discrete counterparts) as a result of the small size and close proximity of t" +
    "he components. As of 2012, typical chip areas range from a few square millimeter" +
    "s to around 450 mm2, with up to 9 million transistors per mm2.\n\nIntegrated circu" +
    "its are used in virtually all electronic equipment today and have revolutionized" +
    " the world of electronics. Computers",
            },
            new CIRCUITSSchema
            {
                Title = "Telecomunication circuits ",
                Subtitle = "information is transmitted ",
                ImageUrl = "/Assets/DataImages/telecommunications_364113957.jpg",
                Description = @"A telecommunication circuit is any line, conductor, or other conduit by which information is transmitted.

A dedicated circuit, private circuit, or leased line is a line that is dedicated to only one use. Originally, this was analog, and was often used by radio stations as a studio/transmitter link (STL) or remote pickup unit (RPU) for their audio, sometimes as a backup to other means. Later lines were digital, and used for private corporate data networks.

The opposite of a dedicated circuit is a switched circuit, which can be connected to different paths. A POTS or ISDN telephone line is a switched circuit, because it can connect to any other telephone number.

On digital lines, a virtual circuit can be created to serve either purpose, while sharing a single physical circuit.A telecommunication circuit may be defined as follows:

The complete path between two terminals over which one-way or two-way communications may be provided. See communications protocol.
An electronic path between two or more points, capable of providing a number of channels.
A number of conductors connected for the purpose of carrying an electric current.
An electronic closed-loop path among two or more points used for signal transfer.
A number of electrical components, such as resistors, inductances, capacitors, transistors, and power sources connected in one or more closed loops.",
            },
		};

        public async override Task<IEnumerable<CIRCUITSSchema>> LoadDataAsync()
        {
            return await Task.Run(() =>
            {
                return _data;
            });
        }
    }
}
