import { Route, BrowserRouter as Router, Routes } from 'react-router-dom';
import { RootPage } from './RootPage';
import { EventsPage } from '@/pages/events/EventsPage';
import { EventPage } from '@/pages/event/EventPage';
import { AuthPage } from '@/pages/auth/AuthPage';
import { LogInForm } from '@/features/auth/ui/LogInForm';
import { SignUpForm } from '@/features/auth/ui/SignUpForm';
import './App.scss';
import { EventFormPage } from '@/pages/add-event/EventFormPage';

function App() {
    return (
        <>
            <Router>
                <Routes>
                    <Route
                        path="/"
                        element={<RootPage />}
                    >
                        <Route
                            index
                            element={<EventsPage />}
                        />
                        <Route
                            path="/events/:eventId"
                            element={<EventPage />}
                        />
                        <Route
                            path="/add-event"
                            element={<EventFormPage />}
                        />
                    </Route>
                    <Route element={<AuthPage />}>
                        <Route
                            path="/login"
                            element={<LogInForm />}
                        />
                        <Route
                            path="signup"
                            element={<SignUpForm />}
                        />
                    </Route>
                </Routes>
            </Router>
        </>
    );
}

export default App;
