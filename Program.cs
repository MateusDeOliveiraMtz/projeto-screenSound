Episodio ep1 = new(1, "Técnicas de facilitação", 45);
ep1.AdicionarConvidados("Maria");
ep1.AdicionarConvidados("Marta");

Episodio ep2 = new(2, "Técnicas de aprendisagem", 67);
ep2.AdicionarConvidados("joão");
ep2.AdicionarConvidados("José");

Episodio ep3 = new(3, "Técnicas em geral", 25);
ep3.AdicionarConvidados("Mateus");
ep3.AdicionarConvidados("Lucas");

Podcast podcast = new Podcast("podcast especial", "Mateus");
podcast.AdicionarEpisodio(ep1);
podcast.AdicionarEpisodio(ep2);
podcast.AdicionarEpisodio(ep3);

podcast.ExibirDetalhes();
