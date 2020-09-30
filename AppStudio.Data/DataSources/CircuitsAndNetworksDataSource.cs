using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class CircuitsAndNetworksDataSource : DataSourceBase<CircuitsAndNetworksSchema>
    {
        protected override string CacheKey
        {
            get { return "CircuitsAndNetworksDataSource"; }
        }

        public override bool HasStaticData
        {
            get { return true; }
        }

        private readonly IEnumerable<CircuitsAndNetworksSchema> _data = new CircuitsAndNetworksSchema[]
		{
            new CircuitsAndNetworksSchema
            {
                Title = "circuits",
                Subtitle = "Active electronic components",
                ImageUrl = "/Assets/DataImages/Circuit-Board-Assembly.jpg",
                Description = @"An electric circuit is a path in which electrons from a voltage or current source flow. Electric current flows in a closed path called an electric circuit. The point where those electrons enter an electrical circuit is called the ""source"" of electrons. The point where the electrons leave an electrical circuit is called the ""return"" or ""earth ground"". The exit point is called the ""return"" because electrons always end up at the source when they complete the path of an electrical circuit. The part of an electrical circuit that is between the electrons' starting point and the point where they return to the source is called an electrical circuit's ""load"".

Electrical circuits usually use alternating current sources. The load of an electrical circuit may be as simple as those from electrical appliances like refrigerators, televisions, or microwave ovens. But the loads for electrical circuits can also be quite complicated, such as the load on the output of a hydroelectric power generating station.

Electronic circuits usually use low voltage direct current sources. The load of an electronic circuit may be as simple as a few resistors, capacitors, and a lamp, all connected together to create the flash in a digital camera. Or an electronic circuit can be complicated, connecting thousands of resistors, capacitors, and transistors to create the microprocessors that make computers possible.",
            },
            new CircuitsAndNetworksSchema
            {
                Title = "Networks ",
                Subtitle = "Interconnections",
                ImageUrl = "/Assets/DataImages/115217519.png",
                Description = @"An electrical network is an interconnection of electrical elements such as resistors, inductors, capacitors, voltage sources, current sources and switches. An electrical circuit is a network consisting of a closed loop, giving a return path for the current. Linear electrical networks, a special type consisting only of sources (voltage or current), linear lumped elements (resistors, capacitors, inductors), and linear distributed elements (transmission lines), have the property that signals are linearly superimposable. They are thus more easily analyzed, using powerful frequency domain methods such as Laplace transforms, to determine DC response, AC response, and transient response.

A resistive circuit is a circuit containing only resistors and ideal current and voltage sources. Analysis of resistive circuits is less complicated than analysis of circuits containing capacitors and inductors. If the sources are constant (DC) sources, the result is a DC circuit.

A network that contains active electronic components is known as an electronic circuit. Such networks are generally nonlinear and require more complex design and analysis tools.",
            },
		};

        public async override Task<IEnumerable<CircuitsAndNetworksSchema>> LoadDataAsync()
        {
            return await Task.Run(() =>
            {
                return _data;
            });
        }
    }
}
