using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class NETWORKSDataSource : DataSourceBase<NETWORKSSchema>
    {
        protected override string CacheKey
        {
            get { return "NETWORKSDataSource"; }
        }

        public override bool HasStaticData
        {
            get { return true; }
        }

        private readonly IEnumerable<NETWORKSSchema> _data = new NETWORKSSchema[]
		{
            new NETWORKSSchema
            {
                Title = "Electrical network",
                Subtitle = "Interconnection of electrical elements ",
                ImageUrl = "/Assets/DataImages/social_network_abstract.png",
                Description = "An electrical network is an interconnection of electrical elements such as resist" +
    "ors, inductors, capacitors, voltage sources, current sources and switches. An el" +
    "ectrical circuit is a network consisting of a closed loop, giving a return path " +
    "for the current. Linear electrical networks, a special type consisting only of s" +
    "ources (voltage or current), linear lumped elements (resistors, capacitors, indu" +
    "ctors), and linear distributed elements (transmission lines), have the property " +
    "that signals are linearly superimposable. They are thus more easily analyzed, us" +
    "ing powerful frequency domain methods such as Laplace transforms, to determine D" +
    "C response, AC response, and transient response.\n\nA resistive circuit is a circu" +
    "it containing only resistors and ideal current and voltage sources. Analysis of " +
    "resistive circuits is less complicated than analysis of circuits containing capa" +
    "citors and inductors. If the sources are constant (DC) sources, the result is a " +
    "DC circuit.\n\nA network that contains active electronic components is known as an" +
    " electronic circuit. Such networks are generally nonlinear and require more comp" +
    "lex design and analysis tools.An active network is a network that consists of at" +
    " least one active source like a voltage source or current source.\n\nA passive net" +
    "work is a network which does not contain any active device.A network is linear i" +
    "f its signals obey the principle of superposition; otherwise it is non-linear. A" +
    " linear network will be composed entirely of independent sources, linear depende" +
    "nt sources and linear passive elements.Ideal Independent Source maintains same v" +
    "oltage or current regardless of the other elements present in the circuit.Its va" +
    "lue is either constant (DC) or sinusoidal (AC). The strength of voltage or curre" +
    "nt is not changed by any variation in connected network.Dependent Sources depend" +
    " upon a particular element of the circuit for delivering the power or voltage or" +
    " current depending upon the type of source it is.",
            },
            new NETWORKSSchema
            {
                Title = "Two-port network",
                Subtitle = " Device with two pairs of terminals",
                ImageUrl = "/Assets/DataImages/images-1.jpg",
                Description = "A two-port network  is an electrical network (circuit) or device with two pairs o" +
    "f terminals to connect to external circuits. Two terminals constitute a port if " +
    "the currents applied to them satisfy the essential requirement known as the port" +
    " condition: the electric current entering one terminal must equal the current em" +
    "erging from the other terminal on the same port. The ports constitute interfaces" +
    " where the network connects to other networks, the points where signals are appl" +
    "ied or outputs are taken. In a two-port network, often port 1 is considered the " +
    "input port and port 2 is considered the output port.\nThe two-port network model " +
    "is used in mathematical circuit analysis techniques to isolate portions of large" +
    "r circuits. A two-port network is regarded as a \"black box\" with its properties " +
    "specified by a matrix of numbers. This allows the response of the network to sig" +
    "nals applied to the ports to be calculated easily, without solving for all the i" +
    "nternal voltages and currents in the network. It also allows similar circuits or" +
    " devices to be compared easily. For example, transistors are often regarded as t" +
    "wo-ports, characterized by their h-parameters (see below) which are listed by th" +
    "e manufacturer. Any linear circuit with four terminals can be regarded as a two-" +
    "port network provided that it does not contain an independent source and satisfi" +
    "es the port conditions.\nExamples of circuits analyzed as two-ports are filters, " +
    "matching networks, transmission lines, transformers, and small-signal models for" +
    " transistors (such as the hybrid-pi model). The analysis of passive two-port net" +
    "works is an outgrowth of reciprocity theorems first derived by Lorentz.\nIn two-p" +
    "ort mathematical models, the network is described by a 2 by 2 square matrix of c" +
    "omplex numbers. The common models that are used are referred to as z-parameters," +
    " y-parameters, h-parameters, g-parameters, and ABCD-parameters",
            },
            new NETWORKSSchema
            {
                Title = "Artificial neural network",
                Subtitle = " computational models",
                ImageUrl = "/Assets/DataImages/images__1_-1.jpg",
                Description = "In machine learning and related fields, artificial neural networks (ANNs) are com" +
    "putational models inspired by an animal\'s central nervous systems (in particular" +
    " the brain) which is capable of machine learning as well as pattern recognition." +
    " Artificial neural networks are generally presented as systems of interconnected" +
    " \"neurons\" which can compute values from inputs.\n\nFor example, a neural network " +
    "for handwriting recognition is defined by a set of input neurons which may be ac" +
    "tivated by the pixels of an input image. After being weighted and transformed by" +
    " a function (determined by the network\'s designer), the activations of these neu" +
    "rons are then passed on to other neurons. This process is repeated until finally" +
    ", an output neuron is activated. This determines which character was read.\n\nLike" +
    " other machine learning methods - systems that learn from data - neural networks" +
    " have been used to solve a wide variety of tasks that are hard to solve using or" +
    "dinary rule-based programming, including computer vision and speech recognition." +
    "The word network in the term \'artificial neural network\' refers to the inter–con" +
    "nections between the neurons in the different layers of each system. An example " +
    "system has three layers. The first layer has input neurons which send data via s" +
    "ynapses to the second layer of neurons, and then via more synapses to the third " +
    "layer of output neurons. More complex systems will have more layers of neurons w" +
    "ith some having increased layers of input neurons and output neurons. The synaps" +
    "es store parameters called \"weights\" that manipulate the data in the calculation" +
    "s.\n\nAn ANN is typically defined by three types of parameters:\n\nThe interconnecti" +
    "on pattern between the different layers of neurons\nThe learning process for upda" +
    "ting the weights of the interconnections\nThe activation function that converts a" +
    " neuron\'s weighted input to its output activation.The utility of artificial neur" +
    "al network models lies in the fact that they can be used to infer a function fro" +
    "m observations.",
            },
            new NETWORKSSchema
            {
                Title = "Computer network",
                Subtitle = "Data network",
                ImageUrl = "/Assets/DataImages/Online-Network-Marketing.png",
                Description = @"A computer network or data network is a telecommunications network that allows computers to exchange data. In computer networks, networked computing devices pass data to each other along data connections. The connections (network links) between nodes are established using either cable media or wireless media. The best-known computer network is the Internet.

Network computer devices that originate, route and terminate the data are called network nodes.Nodes can include hosts such as personal computers, phones, servers as well as networking hardware. Two such devices are said to be networked together when one device is able to exchange information with the other device, whether or not they have a direct connection to each other.

Computer networks support applications such as access to the World Wide Web, shared use of application and storage servers, printers, and fax machines, and use of email and instant messaging applications. Computer networks differ in the physical media used to transmit their signals, the communications protocols to organize network traffic, the network's size, topology and organizational intent.",
            },
            new NETWORKSSchema
            {
                Title = "Radio network",
                Subtitle = "Broadcast networks ",
                ImageUrl = "/Assets/DataImages/RadioTower.jpg",
                Description = "There are two types of radio networks currently in use around the world: the one-" +
    "to-many broadcast network commonly used for public information and mass media en" +
    "tertainment; and the two-way radio type used more commonly for public safety and" +
    " public services such as police, fire, taxicabs, and delivery services. Cell Pho" +
    "nes are able to send and receive simultaneously by using two different frequenci" +
    "es at the same time. Many of the same components and much of the same basic tech" +
    "nology applies to all three.\n\nThe Two-way type of radio network shares many of t" +
    "he same technologies and components as the Broadcast type radio network but is g" +
    "enerally set up with fixed broadcast points (transmitters) with co-located recei" +
    "vers and mobile receivers/transmitters or Transceivers. In this way both the fix" +
    "ed and mobile radio units can communicate with each other over broad geographic " +
    "regions ranging in size from small single cities to entire states/provinces or c" +
    "ountries. There are many ways in which multiple fixed transmit/receive sites can" +
    " be interconnected to achieve the range of coverage required by the jurisdiction" +
    " or authority implementing the system: conventional wireless links in numerous f" +
    "requency bands, fibre-optic links, or micro-wave links. In all of these cases th" +
    "e signals are typically backhauled to a central switch of some type where the ra" +
    "dio message is processed and resent (repeated) to all transmitter sites where it" +
    " is required to be heard.\n\nIn contemporary two-way radio systems a concept calle" +
    "d trunking is commonly used to achieve better efficiency of radio spectrum use a" +
    "nd provide very wide ranging coverage with no switching of channels required by " +
    "the mobile radio user as it roams throughout the system coverage. Trunking of tw" +
    "o-way radio is identical to the concept used for cellular phone systems where ea" +
    "ch fixed and mobile radio is specifically identified to the system Controller an" +
    "d its operation is switched by the controller. See also the entries Two-way radi" +
    "o and Trunked radio system",
            },
            new NETWORKSSchema
            {
                Title = "Telecommunications network",
                Subtitle = "Telecommunications",
                ImageUrl = "/Assets/DataImages/1-shutterstock_59286082.jpg",
                Description = @"A telecommunications network is a collection of terminal nodes, links and any intermediate nodes which are connected so as to enable telecommunication between the terminals.[1]

The transmission links connect the nodes together. The nodes use circuit switching, message switching or packet switching to pass the signal through the correct links and nodes to reach the correct destination terminal.

Each terminal in the network usually has a unique address so messages or connections can be routed to the correct recipients. The collection of addresses in the network is called the address space.

Examples of telecommunications networks are:[2]

computer networks
the Internet
the telephone network
the global Telex network
the aeronautical ACARS networkIn general, every telecommunications network conceptually consists of three parts, or planes (so called because they can be thought of as being, and often are, separate overlay networks):

The control plane carries control information (also known as signalling).
The data plane or user plane or bearer plane carries the network's users traffic.
The management plane carries the operations and administration traffic required for network management.",
            },
		};

        public async override Task<IEnumerable<NETWORKSSchema>> LoadDataAsync()
        {
            return await Task.Run(() =>
            {
                return _data;
            });
        }
    }
}
