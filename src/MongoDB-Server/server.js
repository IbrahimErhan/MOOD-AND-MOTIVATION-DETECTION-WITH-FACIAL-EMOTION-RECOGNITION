const Express = require("express");
const BodyParser = require("body-parser");
const MongoClient = require("mongodb").MongoClient;
const ObjectId = require("mongodb").ObjectID;
const CONNECTION_URL = "";
const DATABASE_NAME = "DB01";

// Add document command : curl -X POST -H 'content-type:application/json' -d 'data0001' http://localhost:5000/COLS01
// Get all documents : curl -X GET http://localhost:5000/COLS01

var app = Express();
app.use(BodyParser.json());
app.use(BodyParser.urlencoded({extended: true}));
var database, collection;

app.listen(5000, () => {
    MongoClient.connect(CONNECTION_URL, { useNewUrlParser: true }, (error, client) => {
        if(error) {
            throw error;
        }
        database = client.db(DATABASE_NAME);
        collection = database.collection("COLS01");
        console.log("Connected to `" + DATABASE_NAME + "`!");
    });
});

app.post("/COLS01", (request, response) => {
    collection.insert(request.body, (error, result) => {
        if(error) {
            return response.status(500).send(error);
        }
        response.send(result.result);
    });
});

app.get("/COLS01", (request, response) => {
    collection.find({}).toArray((error, result) => {
        if(error) {
            return response.status(500).send(error);
        }
        response.send(result);
    });
});
app.get("/FindOneCOLS01", (request, response) => {
    collection.findOne({  }, (error, result) => {
        if(error) {
            return response.status(500).send(error);
        }
        response.send(result);
    });
});

app.get("/COLS01/:id", (request, response) => {
    collection.findOne({ "_id": new ObjectId(request.params.id) }, (error, result) => {
        if(error) {
            return response.status(500).send(error);
        }
        response.send(result);
    });
});

app.get("/DelCOLS01/:id", (request, response) => {
    collection.deleteOne({ "_id": new ObjectId(request.params.id) }, (error, result) => {
        if(error) {
            return response.status(500).send(error);
        }
        response.send(result);
    });
});



app.get("/GetCOLS01/:dataCounter", (request, response) => {
    collection.find({ "dataCounter": request.params.dataCounter }).toArray((error, result) => {
        if(error) {
            return response.status(500).send(error);
        }
        response.send(result);
    });
});
