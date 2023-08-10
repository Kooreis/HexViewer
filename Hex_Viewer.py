```python
import sys

def main():
    try:
        file_name = sys.argv[1]
    except IndexError:
        print("Please specify a file name.")
        sys.exit(1)

    try:
        with open(file_name, 'rb') as f:
            while True:
                chunk = f.read(16)
                if chunk:
                    print(' '.join(f'{i:02x}' for i in chunk), end=' ')
                    print(''.join((chr(i) if 32 <= i < 127 else '.') for i in chunk))
                else:
                    break
    except FileNotFoundError:
        print(f"No such file: '{file_name}'")
        sys.exit(1)

if __name__ == "__main__":
    main()
```