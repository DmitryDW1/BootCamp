from flask_wtf import FlaskForm
from wtforms import StringField, PasswordField, BooleanField, SubmitField
from wtforms.validators import DataRequired


class Lf(FlaskForm):
    name = StringField("Имя", validators=[DataRequired()])
    email = StringField("Почта", validators=[DataRequired()])
    password = StringField("Пароль", validators=[DataRequired()])
    password_again = StringField("Повторите пароль", validators=[DataRequired()])
    remember_me = BooleanField("Запомнить меня", validators=[DataRequired()])
    submit = SubmitField("Зарегистрироваться")