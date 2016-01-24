import os
import json
from jinja2 import Environment, FileSystemLoader

PATH = os.path.dirname(os.path.abspath(__file__))
TEMPLATE_ENVIRONMENT = Environment(
    autoescape=False,
    loader=FileSystemLoader(os.path.join(PATH, 'templates')),
    trim_blocks=False)

def render_template(template_filename, data):
    return TEMPLATE_ENVIRONMENT.get_template(template_filename).render(data=data)

def create_csharp_code(context):
    fname = "MQL.cs"
    with open(fname, 'w') as f:
        code = render_template('csharp.template', context)
        f.write(code)

    fname = "MQLCommand.cs"
    with open(fname, 'w') as f:
        code = render_template('command_enum.template', context)
        f.write(code)

def main():
    with open('function.dump.json') as json_data:
        data = json.load(json_data)
    create_csharp_code(data)

if __name__ == "__main__":
    main()