using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AppStudio.Data
{
    public class ELECTRONICSDataSource : DataSourceBase<HtmlSchema>
    {
        private IEnumerable<HtmlSchema> _data = new HtmlSchema[]
        {
            new HtmlSchema
            {
                Id = "{97d6610d-1b97-49a3-8f48-d016f8845922}",
                Content = "<div><b><i>Electronics deals with electrical circuits that involve active electri" +
    "cal components such as vacuum tubes, transistors, diodes and integrated circuits" +
    ", and associated passive interconnection technologies. Commonly, electronic devi" +
    "ces contain circuitry consisting primarily or exclusively of active semiconducto" +
    "rs supplemented with passive elements; such a circuit is described as an electro" +
    "nic circuit.</i></b></div><div><br></div><div><b><i>The nonlinear behaviour of a" +
    "ctive components and their ability to control electron flows makes amplification" +
    " of weak signals possible and electronics is widely used in information processi" +
    "ng, telecommunication, and signal processing. The ability of electronic devices " +
    "to act as switches makes digital information processing possible. Interconnectio" +
    "n technologies such as circuit boards, electronics packaging technology, and oth" +
    "er varied forms of communication infrastructure complete circuit functionality a" +
    "nd transform the mixed components into a regular working system.</i></b></div><d" +
    "iv><br></div><div><b><i>Electronics is distinct from electrical and electro-mech" +
    "anical science and technology, which deal with the generation, distribution, swi" +
    "tching, storage, and conversion of electrical energy to and from other energy fo" +
    "rms using wires, motors, generators, batteries, switches, relays, transformers, " +
    "resistors, and other passive components. This distinction started around 1906 wi" +
    "th the invention by Lee De Forest of the triode, which made electrical amplifica" +
    "tion of weak radio signals and audio signals possible with a non-mechanical devi" +
    "ce. Until 1950 this field was called \"radio technology\" because its principal ap" +
    "plication was the design and theory of radio transmitters, receivers, and vacuum" +
    " tubes.</i></b></div><div><br></div><div><b><i>Today, most electronic devices us" +
    "e semiconductor components to perform electron control. The study of semiconduct" +
    "or devices and related technology is considered a branch of solid-state physics," +
    " whereas the design and construction of electronic circuits to solve practical p" +
    "roblems come under electronics engineering. This article focuses on engineering " +
    "aspects of electronics.</i></b></div><p><span class=\"wysiwyg-font-size-medium\">\n" +
    "</span></p>"
            }
        };

        protected override string CacheKey
        {
            get { return "ELECTRONICSDataSource"; }
        }

        public override bool HasStaticData
        {
            get { return true; }
        }

        public async override Task<IEnumerable<HtmlSchema>> LoadDataAsync()
        {
            return await Task.Run(() =>
            {
                return _data;
            });
        }
    }
}
