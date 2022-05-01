import admin from 'firebase-admin';

import serviceAccount  from '../../credentials/voyager-f1f0c-firebase-adminsdk-8f923-4ffbcfbe13.json';


admin.initializeApp({
    credential: admin.credential.cert(serviceAccount),
});

export default admin;