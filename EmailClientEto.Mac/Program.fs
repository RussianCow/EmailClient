namespace EmailClientEto.Mac

module Program =

    open System
    open EmailClientEto

    [<EntryPoint>]
    [<STAThread>]
    let Main (args) =
        let app = new EmailClientApplication(Eto.Platforms.Mac64)
        app.Run()
        0
