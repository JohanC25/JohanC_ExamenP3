﻿using JohanC_ExamenP3.Data;

namespace JohanC_ExamenP3;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

		string dbPath = FileAccessHelper.GetLocalFilePath("marvel.db3");
		builder.Services.AddSingleton<JCMarvelDatabase>(s => ActivatorUtilities.CreateInstance<JCMarvelDatabase>(s, dbPath));

		return builder.Build();
	}
}
