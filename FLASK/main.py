from flask import Flask


app = Flask(__name__)


@app.route('/')
def main():
    return "<h1>Hello World</h1><br><a href='/index'>перейти на 2-ю страницу</a>"


@app.route('/index')
def index():
    return "It's my first project"


if __name__ == '__main__':
    app.run()