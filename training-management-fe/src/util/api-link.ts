
const baseURL = "http://localhost:5176/api"

const apiLinks = {
    email: {
        get_email: `${baseURL}/Mail`,
        send_email: `${baseURL}/Mail/smtp`,
    },
    auth : {
        get_token: `${baseURL}/Mail/token`,
        
    },
    syllabus:{
        get_syllabus : `${baseURL}/Syllabuses`
    },
    trainingClass:{
        get_training_class : `${baseURL}/trainingClasses`
    }
}

export default apiLinks;