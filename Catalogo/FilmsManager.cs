using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Catalogo
{
    public class FilmsManager
    {
        public static ObservableCollection<Film> Films = new ObservableCollection<Film>() {
            new Film(0, "Minions", "http://image.tmdb.org/t/p/w500/4gX0M4RifoqXBz9LejqQ6wYPqYo.jpg", 221.108879, "Seres amarelos milenares, os minions têm uma missão: servir os maiores vilões. Em depressão desde a morte de seu antigo mestre, eles tentam encontrar um novo chefe. Três voluntários, Kevin, Stuart e Bob, vão até uma convenção de vilões nos Estados Unidos e lá se encantam com Scarlet Overkill (Sandra Bullock), que ambiciona ser a primeira mulher a dominar o mundo."),
            new Film(1, "A Bela e a Fera", "http://image.tmdb.org/t/p/w500/9V4wl4rnUcLfGuTe4J5NjOFbDil.jpg", 110.559899, "Moradora de uma pequena aldeia francesa, Bela (Emma Watson) tem o pai capturado pela Fera e decide entregar sua vida ao estranho ser em troca da liberdade do progenitor. No castelo ela conhece objetos mágicos e descobre que a Fera é na verdade um príncipe que precisa de amor para voltar à forma humana."),
            new Film(2, "Homem-Aranha: De Volta ao Lar", "http://image.tmdb.org/t/p/w500/9C8NPGOpDUDPRVe5gSrAayQhPkL.jpg", 76.525143, "Depois de atuar ao lado dos Vingadores, chegou a hora do pequeno Peter Parker (Tom Holland) voltar para casa e para a sua vida, já não mais tão normal. Lutando diariamente contra pequenos crimes nas redondezas, ele pensa ter encontrado a missão de sua vida quando o terrível vilão Abutre (Michael Keaton) surge amedrontando a cidade. O problema é que a tarefa não será tão fácil como ele imaginava."),
            new Film(3, "Guardiões da Galáxia Vol. 2", "http://image.tmdb.org/t/p/w500/1LFSuOFtbRDIuBbwuNVgTTn0Lq4.jpg", 58.09555, "Peter Quill (Chris Pratt), Gamora (Zoe Saldana), Rocket Racoon (voz de Bradley Cooper), Baby Groot (voz de Vin Diesel) e Drax (Dave Bautista) provaram que, apesar das desavenças, formam uma equipe e tanto. Agora, Peter descobre segredos sobre a identidade de seu pai e na busca por ele, inimigos acabam se tornando aliados."),
            new Film(4, "Meu Malvado Favorito 3", "http://image.tmdb.org/t/p/w500/C22MaUfTyb2tDxsvtjH4i3d9FT.jpg", 57.734517, "Meu Malvado Favorito está de volta, agora com um novo vilão. O ex-ator mirim e astro de TV Balthazar Bratt foi um típico malvado bem-sucedido nos anos 80. De volta à ativa, ele ocupará o posto de novo supervilão em “Meu Malvado Favorito 3” (Despicable Me 3) e causará o terror na vida de Gru, Agnes, Margo, Edith, Dr. Nefario e os atrapalhados Minions."),
            new Film(5, "Annabelle 2: A Criação do Mal", "http://image.tmdb.org/t/p/w500/vNwbTiSMs40xVP3HGOBYR23PFHJ.jpg", 57.37885, "Anos após a trágica morte de sua filha, um habilidoso artesão de bonecas e sua esposa decidem, por caridade, acolher em sua casa uma freira e dezenas de meninas desalojadas de um orfanato. Atormentado pelas lembranças traumáticas, o casal ainda precisa lidar com um amedrontador demônio do passado: Annabelle, criação do artesão.")
        };
    }
}