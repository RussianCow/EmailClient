namespace EmailClientEto

open Eto.Forms

type EmailClientApplication(platformType: string) as this =
    inherit Eto.Forms.Application(platformType)

    let loginForm = new LoginForm()
    let emailForm = new EmailForm()

    do
        loginForm.LoginAdded
        |> Event.add (fun payload ->
            MessageBox.Show("Logged in with " + payload.Text)
            |> ignore)

        this.ShowEmailForm()
        this.ShowLoginForm()

    member this.ShowLoginForm() =
        do
            loginForm.Show()
            emailForm.Visible <- false

    member this.ShowEmailForm() =
        do
            emailForm.Show()
            loginForm.Visible <- false
