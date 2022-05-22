from email.mime import base
import os


def read(path):
    f = open(path, 'r')
    content = f.read()
    return content

def removeTrallingStr(content, str):
    content = content.strip()
    if content[- len(str):] == str:
        content = content[:- len(str)]
        return False, content
    return True, ""

def write(content, path):
    f = open(path, 'w')
    f.write(content)
    f.close()

base_dir = [os.path.join('.', 'Algorithms'), os.path.join('.', 'Database'), os.path.join('.', 'Shell')]

str = ['cs', 'sql', 'bash']

for i in range(len(base_dir)):
    files = os.listdir(base_dir[i])
    for file in files:
        file_path = os.path.join(base_dir[i], file)
        print(file_path)
        content = read(file_path)

        already_correct, new_content = removeTrallingStr(content, str[i])

        if not already_correct:
            write(new_content, file_path)
            