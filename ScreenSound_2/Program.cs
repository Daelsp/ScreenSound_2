Episodio ep1 = new(2, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marcelo");
Console.WriteLine(ep1.Resumo);

Episodio ep2 = new(1, "Técnicas de aprendizado", 60);
ep1.AdicionarConvidados("Dael");
ep1.AdicionarConvidados("Lucas");
ep2.AdicionarConvidados("Marcos");
Console.WriteLine(ep1.Resumo);

Podcast podcast = new("Podcast especial", "Daniel");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.ExibirDetalhes();