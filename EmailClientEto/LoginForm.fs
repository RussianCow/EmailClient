namespace EmailClientEto

open Eto.Forms
open Eto.Drawing

type LoginPayload = { Text: string }

type LoginForm() as this =
    inherit Form()

    let addLoginEvent = new Event<LoginPayload>()

    do
        this.Title <- "Log In"
        this.MinimumSize <- new Size(400, 400)
        this.Padding <- new Padding(10)

        let layout = new StackLayout()
        layout.Items.Add(new StackLayoutItem(new Label(Text = "Log into your email account")))
        let textBox = new TextBox()
        layout.Items.Add(new StackLayoutItem(textBox))
        let button = new Button(Text = "Log In")
        button.Click.Add(fun _ -> addLoginEvent.Trigger({ Text = textBox.Text }))
        layout.Items.Add(new StackLayoutItem(button))

        this.Content <- layout

    [<CLIEvent>]
    member this.LoginAdded = addLoginEvent.Publish
