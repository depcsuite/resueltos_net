using Microsoft.AspNetCore.Mvc;
using System.Globalization;
using TiendaLibros.Models;

namespace TiendaLibros.Controllers
{

    [Route("[controller]")]
    [ApiController]
    public class LibrosController : Controller
    {
    
        [HttpGet]
        public IActionResult Index()
        {
            //Mostrar libros mas vendidos.

            var librosDto = GetLibrosDto();

            if (librosDto == null)
            {
                ErrorViewModel error = new ErrorViewModel()
                {
                    RequestId = Guid.NewGuid().ToString(),

                };
                return View("Error");
            }

    
            return View(librosDto);
        }


        [HttpGet]
        [Route("{isbn?}")]
        public IActionResult Index(string isbn)
        {
            //Mostrar libros mas vendidos.

            //var libros = GetMejoresVentasLibros(isbn);
            var libros = GetLibrosDto();

            var libroDto = libros.Where(x => x.ISBN == isbn).FirstOrDefault();

            if (libroDto == null)
            {
                ErrorViewModel error = new ErrorViewModel()
                {
                    RequestId = Guid.NewGuid().ToString(),

                };
                return View("Error");
            }

            return View(libroDto);
        }

        [HttpGet]
        [Route("{detalles}/{isbn?}")]
        public IActionResult Detalles(string isbn)
        {
            //Mostrar libros mas vendidos.

            //var libros = GetMejoresVentasLibros(isbn);
            var libros = GetLibrosDto();

            var libroDto = libros.Where(x => x.ISBN == isbn).FirstOrDefault();

            if (libroDto == null)
            {
                ErrorViewModel error = new ErrorViewModel()
                {
                    RequestId = Guid.NewGuid().ToString(),

                };
                return View("Error");
            }

            return View(libroDto);
        }

        //Simula la consulta a la DB.
        private List<LibroDto> GetLibrosDto()
        {
            //Consulto los mas vendidos.

            List<LibroDto> libros = new List<LibroDto>()
            {
            new LibroDto()
            {
                Ranking = 9,
                ISBN = "100",
                Titulo = "100 años de Soledad",
                Autor = "Garcia Marquez",
                Precio = 2300,
                PortadaLink = "100.png",
                Detalles = new LibrosDetalleDto()
                {
                    FechaPublicacion =  DateTime.ParseExact("10-02-1990","MM-dd-yyyy", CultureInfo.CurrentCulture),
                    Genero = "Novela",
                    Resumen = "Es de huido abeja lentejas de la pero carcajadas me hule luna comida se para la pero llenando donde las es el quedo mujer las en manecitas dando ninos las diminutas desnudo mío de escaleras de y quedo para abrir latido es al de los que que y aire faraón sin que tierra que de heridas nino es de borrachos por la de por tierra la tierra de la que nino osos un entonces se mujer nino que me dios los los perfil perfil pasan deja dolor ojos comida la bajo nino inocentes y tan faraón para lentejas pasan alegrísima y con la pero y con manos pero transparente luna las no la la los con consume manteles lo muelles donde acaba árboles es de de brooklyn buscando el que bajo escaleras la pensamiento estremecidos que atrás consume con y pulso en lentejas muelles arcos nino y es el que baja nino diana y las ilesa que paso que tránsito quedo de manecitas hule deja con lo los queman huye diana del arroyo con brooklyn faraón lentejas el se quedo que la nunca encuentro tránsito no luna apariencia de encuentro bajo con se sus cielo alegrísima arroyo bajo y bajo"
                }
            },
            new LibroDto()
            {
                Ranking = 9,
                ISBN = "101",
                Titulo = "La metaforfosis",
                Autor = "Kafka",
                Precio = 3300,
                PortadaLink = "101.png",
                Detalles = new LibrosDetalleDto()
                {
                    FechaPublicacion =  DateTime.ParseExact("10-02-1900","MM-dd-yyyy", CultureInfo.CurrentCulture),
                    Genero = "Novela",
                    Resumen = "Menedékünk ölel kicifrázva ríjjátok rázza gyalázat míg ríjjátok égjen nem és meg mint de bukjatok egymást ellökött neki minden vágy de fáj tagadta el lel száj a nagyon kínt szeret rázza ahol neki¨nagyon ártatlanok mégis táj hol azt kivül teher mégis nemcsak de nap s nem ha csereg szenvednem is nemcsak kezében kitaszít a kivül ha s hontalan ugassátok nincsen hull ölel te nagyon fáj gyámoltalan de hagyottan hontalan halak megremeg a neki elvetéljetek fáj halál fáj mint segítsetek élõ s nõ mégis lukba minden lukba egyéb ezért jár égjen bukjatok alá anyádnak férfiak kerüljetek ki ríjjátok ellene hû így jég szeret s s és elvetéljetek énekem kerüljetek neki élõ mondjátok ártatlanok fájdalmas fáj meg kerék igát a hoz emberek belõl kell és élõk de találhat vágy menekülõ amíg a s a fáj nincsen fehérül a a s csereg nem olyat a a sikongjatok vadállat de odataszít is fehérül belõl csörgõ fájdalmas lovak fáj gondom fáj kultúra kapjatok s hull pattanjon a sikongjatok nem lovak zúg hogy szavakat kínt szükségét térde végzõ mi párra közt nap herélnek térde a legutolsó de szenvedi kapjatok megriadt és s a kert kénye le meg egymást kivül laktok ti igát kíntól szükségét és táj"
                }

            },
            new LibroDto()
            {

                Ranking = 3,
                ISBN = "102",
                Titulo = "Como ganar tu primer Millon",
                Autor = "Mario Quintero",
                Precio = 2800,
                PortadaLink = "102.png",
                Detalles = new LibrosDetalleDto()
                {
                    FechaPublicacion =  DateTime.ParseExact("10-02-2020","MM-dd-yyyy", CultureInfo.CurrentCulture),
                    Genero = "Novela",
                    Resumen = "Éclairs fileur sillage d'europe plein qu'on la montait fleurs atroce est-ce bleu courais pôles neiges les lunules femme mais de coups si quelque et plus et flottaison l'orgueil que léviathan dorades mer mer des libre les - une les bouchon toute d'europe sais marées moi flot les des hideux jeté avec sous de les léger la au vrai travers blonds a le des bouchon soleil et vomissures des aubes des vers cieux j'aurais bons j'ai fond sur un nasses dont rousseurs regrette arcs-en-ciel rougeoyant aux vu l'alcool dorades quand loin ultramarins les que lumineux lactescent plus le l'oeil courais montant mers florides braises heurté bleus verts oiseau des le rousseurs de ameres jaune de inouies que ameres brides l'éther par des ventouses d'argent au soir les dérades bouchon golfes ma qu'un un mers subi a j'ai soir haleurs parfums lactescent vers blonds descend ardents qu'une d'argent et et poteaux éveils toute lyres d'hommes aux et des la les de montant genoux ces m'ont enfants dix pensif le en querelles du sentant rutilements j'aille fermenter suivi soleil jaune qui l'âcre les au et hiver hystériques les et poteaux qui de d'or de ainsi les de fleurs équipages d'ineffables ou querelles mois"
                }

            },
            new LibroDto()
            {
                Ranking = 8,
                ISBN = "103",
                Titulo = "La guerra de la triple alianza",
                Autor = "Garcia Belsunse ",
                Precio = 5300,
                PortadaLink = "103.png",
                Detalles = new LibrosDetalleDto()
                {
                    FechaPublicacion =  DateTime.ParseExact("10-02-1985","MM-dd-yyyy", CultureInfo.CurrentCulture),
                    Genero = "Novela",
                    Resumen = "Clita magna rebum euismod aliquam eos aliquip ea nostrud kasd duis justo labore ea dolore ullamcorper tincidunt ipsum et luptatum vero sit accusam ipsum lorem enim hendrerit vero ea ut sit nibh ipsum enim lorem diam ea ut sit gubergren lobortis kasd dolore lorem et et justo autem amet duis stet sit dolores vel rebum duo diam et accusam no nulla dolore lorem takimata euismod et accusam eirmod augue iusto nonumy nonumy takimata sanctus magna clita dolore duo et at te dolor tempor amet elitr dolores diam ea luptatum tempor lorem ipsum aliquyam molestie nulla eos clita vero tation sit sea amet autem rebum in invidunt nostrud kasd sit sit et kasd duo sit vel blandit diam blandit ea minim sadipscing dignissim erat sadipscing et aliquyam sea ut kasd at amet feugait facilisis clita vel nonumy et in clita sit laoreet et duo ea laoreet nam dolore ut justo clita nonumy clita sed lorem ipsum tempor facilisis velit nostrud sea ea elitr lorem et sit takimata ut rebum sed lorem ut est odio stet nonumy diam blandit et velit dolores vel vero magna amet erat sanctus magna sed volutpat stet eleifend in magna lorem tempor sed dolores te delenit ea"
                }

            },
            new LibroDto()
            {

                Ranking = 2,
                ISBN = "104",
                Titulo = "Predicciones 2023",
                Autor = "Ludovica Skuir",
                Precio = 1000,
                PortadaLink = "104.png",
                Detalles = new LibrosDetalleDto()
                {
                    FechaPublicacion =  DateTime.ParseExact("10-02-2022","MM-dd-yyyy", CultureInfo.CurrentCulture),
                    Genero = "Novela",
                    Resumen = "Neu es schöne faßt dunst einst froher trüben mein klage tränen zu zu die und folgenden der und nicht alten ich schatten getäuscht zug neu ich der trüben lied denen tönen gleich mein die zerstoben tönen menge und macht zu euch trüben faßt versuch liebe bilder vom mir denen strenge euch herzen strenge ich ihr diesmal fühlt mein die menge wiederholt zauberhauch sage euch gedränge früh und lauf ich der den menge beifall freundschaft blick vor nennt des ich noch und geneigt mir ernsten um ihr ich den euch glück fühlt klage die schwankende in sich lied freundliche stunden euch verschwand ernsten denen lied wieder irren wieder die den entwöhntes unbekannten glück bringt kommt auf euch welt ich nun des wohl klage mögt die weich die sage der ihr schwankende ernsten schauer besitze macht geneigt sie das geisterreich nach die nun lebens ihr hinweggeschwunden gleich des zu und sonst nennt froher nun längst trüben mich sang unbekannten euch längst denen festzuhalten der folgt faßt und ein seelen lied sich in erfreuet was ein nach mit beifall die selbst widerklang hinweggeschwunden schatten klage was dunst noch beifall ich tränen nennt die mich vor früh jugendlich ich mich seelen drängt gesänge festzuhalten"
                }

            }
        };

            return libros;
        }

    }
}
