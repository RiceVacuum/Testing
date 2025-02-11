body {
    margin: 0;
    font-family: Arial, sans-serif;
    background-color: #001f3f; /* Dark blue background */
    color: white;
}

.navbar {
    position: fixed;
    top: 0;
    width: 100%;
    background-color: #003366; /* Darker blue for the navbar */
    padding: 10px;
    display: flex;
    justify-content: space-around;
}

button {
    background-color: #00509e; /* Button color */
    color: white;
    border: none;
    padding: 10px 20px;
    cursor: pointer;
    transition: transform 0.2s;
}

button:hover {
    background-color: #007acc; /* Lighter blue on hover */
}

.section {
    margin-top: 60px; /* Space for fixed navbar */
    padding: 20px;
}

.active {
    transform: scale(1.1); /* Grow effect for active button */
}
