import os
import shutil
from datetime import datetime

# Path to the folder containing MP4 files
home = os.path.expanduser("~")  # Get the home directory
source_folder = os.path.join(home, "Documents", "Mobile Videos")  # Adjusted path

# Iterate through files in the folder
for file_name in os.listdir(source_folder):
    if file_name.lower().endswith(".mp4"):  # Process only MP4 files
        file_path = os.path.join(source_folder, file_name)

        # Get the modification date of the file
        mod_time = os.path.getmtime(file_path)
        mod_date = datetime.fromtimestamp(mod_time).strftime("%Y-%m-%d")

        # Destination folder based on modification date
        date_folder = os.path.join(source_folder, mod_date)
        os.makedirs(date_folder, exist_ok=True)  # Create folder if not exists

        # Move the file into the date-based folder
        shutil.move(file_path, os.path.join(date_folder, file_name))

print("Files organized successfully!")
