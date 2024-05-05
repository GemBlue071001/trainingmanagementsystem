import {
    createSlice,
    createAsyncThunk,
    PayloadAction,
    CaseReducer,
} from '@reduxjs/toolkit';
import { Email } from '../model/email/email';
import emailService from '../services/emailService';

type CR<T> = CaseReducer<State, PayloadAction<T>>;

const TYPE_PREFIX = 'user/email/';

interface State {
    emailList: Email[]
}

const initialState: State = {
    emailList: []
};

const getListEmail = createAsyncThunk(
    `${TYPE_PREFIX}getListEmail`,
    async () => {
        const result = await emailService.getListEmail();
        return result;
    },
);

const slice = createSlice({
    name: 'admin/management-task/folder',
    initialState,
    reducers: {

    },
    extraReducers: (builder) => {
        // get project folder by id
        builder.addCase(getListEmail.pending, (state) => ({
            ...state,
            
        }));
        builder.addCase(getListEmail.fulfilled, (state, { payload }) => ({
            ...state,
            emailList:payload
        }));
        builder.addCase(getListEmail.rejected, (state) => ({
            ...state,
            
        }));
    },
});

export { getListEmail };

export const { } = slice.actions;

export default slice.reducer;

