# Equation

Form size			960x540
Form border style 		none
Start position			CenterScreen



Higher Location of ball 387, 72
Lower Location of ball 387, 152


Location of Black 105, 210
black box down 105, 304



private void Start_MouseEnter(object sender, EventArgs e)
        {
            Start.FlatAppearance.BorderSize = 1;
            Start.BackColor = Color.Green;
            Start.FlatAppearance.BorderColor = Color.Green;
        }


private void Start_MouseLeave(object sender, EventArgs e)
        {
            Start.FlatAppearance.BorderSize = 0;
            Start.BackColor = Color.White;
            Start.FlatAppearance.BorderColor = MainMenu.DefaultBackColor;
        }


