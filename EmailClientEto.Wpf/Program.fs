namespace EmailClientEto.Wpf

module Program =

    open System
    open EmailClientEto

    [<EntryPoint>]
    [<STAThread>]
    let Main (args) =
        let app = new EmailClientApplication(Eto.Platforms.Wpf)
        app.Run()
        0
