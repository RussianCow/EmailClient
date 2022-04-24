namespace EmailClientEto.Gtk

module Program =

    open System
    open EmailClientEto

    [<EntryPoint>]
    [<STAThread>]
    let Main (args) =
        let app = new EmailClientApplication(Eto.Platforms.Gtk)
        app.Run()
        0
