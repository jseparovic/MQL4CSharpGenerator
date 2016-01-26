import os
import json
from jinja2 import Environment, FileSystemLoader

PATH = os.path.dirname(os.path.abspath(__file__))
TEMPLATE_ENVIRONMENT = Environment(
    autoescape=False,
    loader=FileSystemLoader(os.path.join(PATH, 'templates')),
    trim_blocks=False)

TEMPLATE_ENVIRONMENT.trim_blocks = True
TEMPLATE_ENVIRONMENT.lstrip_blocks = True

def render_template(template_filename, data):
    return TEMPLATE_ENVIRONMENT.get_template(template_filename).render(data=data)

def create_csharp_code(context):
    fname = "out/MQL.cs"
    with open(fname, 'w') as f:
        code = render_template('csharp.template', context)
        f.write(code)

    fname = "out/MQLCommand.cs"
    with open(fname, 'w') as f:
        code = render_template('command_enum.template', context)
        f.write(code)

def create_mql_code(context):
    fname = "out/mc_funcs.mqh"
    with open(fname, 'w') as f:
        code = render_template('mql.funcs.template', context)
        f.write(code)

    fname = "out/mc_returns.mqh"
    with open(fname, 'w') as f:
        code = render_template('mql.returns.template', context)
        f.write(code)

def create_mql_helpers(context):
    fname = "out/mc_helpers.mqh"
    tplfile = 'mql.helpers.template'

    enumData = []
    for i in ['ALIGN_MODE', 'COLOR', 'OBJECT', 'SIGNAL_BASE_DOUBLE', 'SIGNAL_BASE_INTEGER', 'SIGNAL_BASE_STRING', 'SIGNAL_INFO_DOUBLE', 'SIGNAL_INFO_INTEGER', 'SIGNAL_INFO_STRING', 'TIMEFRAMES']:
        with open('enumlists/' + i) as enums:
            lines = enums.readlines()
            inputs = []
            for line in lines:
                inputs.append(line.rstrip("\n"))

            enumData.append({'type': i, 'inputs': inputs})
    with open(fname, 'w') as f:
        code = render_template(tplfile, enumData)
        f.write(code)


def main():

    with open('function.dump.json') as json_data:
        data = json.load(json_data)
    create_csharp_code(data)
    create_mql_code(data)
    create_mql_helpers(data)

if __name__ == "__main__":
    main()