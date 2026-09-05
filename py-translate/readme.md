
-> create a virtual environment (helpfull not needed)
python -m venv .venv
-> activate v env
.venv\scripts\activate
-> install req
; pip install torch --index-url https://download.pytorch.org/whl/cu124
pip install -r requirements.txt
-> start script
python main.py

takes the english.xml in the same directory and outputs to all languages not commented