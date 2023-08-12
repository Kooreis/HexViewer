def main():
    try:
        file_name = sys.argv[1]
    except IndexError:
        print("Please specify a file name.")
        sys.exit(1)