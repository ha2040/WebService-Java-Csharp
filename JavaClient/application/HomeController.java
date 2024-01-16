
	package application;

	import javafx.event.ActionEvent;
	import javafx.fxml.FXML;
	import javafx.fxml.FXMLLoader;
	import javafx.scene.Scene;
	import javafx.scene.layout.AnchorPane;
	import javafx.stage.Stage;
	import javafx.scene.Node;

	public class HomeController {
		private Main main;
		private Stage stage;
		private Scene scene;
		private AnchorPane root;

		// setters and getters
		public void setMain(Main main) {
			this.main = main;
		}

		public Stage getStage() {
			return stage;
		}

		public void setStage(Stage stage) {
			this.stage = stage;
		}

		public Scene getScene() {
			return scene;
		}

		public void setScene(Scene scene) {
			this.scene = scene;
		}

		public AnchorPane getRoot() {
			return root;
		}

		public void setRoot(AnchorPane root) {
			this.root = root;
		}

		public Main getMain() {
			return main;
		}
		@FXML
		public void btnSwitchToFaculties(ActionEvent event) throws Exception {
			FXMLLoader loader = new FXMLLoader(getClass().getResource("FacultyScene.fxml"));
			root = loader.load();
			stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
			scene = new Scene(root);

			stage.setScene(scene);
			stage.show();

			FacultyController facultyController = loader.getController();
			facultyController.setMain(main);
		}
		@FXML
		public void btnSwitchToEmployees(ActionEvent event) throws Exception {
			FXMLLoader loader = new FXMLLoader(getClass().getResource("EmployeeScene.fxml"));
			root = loader.load();
			stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
			scene = new Scene(root);

			stage.setScene(scene);
			stage.show();

			EmployeeController employeeController = loader.getController();
			employeeController.setMain(main);
		}


		// Buttons to change scenes
		@FXML
		public void btnSwitchToHome(ActionEvent event) throws Exception {
			FXMLLoader loader = new FXMLLoader(getClass().getResource("HomeScene.fxml"));
			root = loader.load();
			stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
			scene = new Scene(root);

			stage.setScene(scene);
			stage.show();

			HomeController homeController = loader.getController();
			homeController.setMain(main);
		}

		@FXML
		public void btnSwitchToStudents(ActionEvent event) throws Exception {
			FXMLLoader loader = new FXMLLoader(getClass().getResource("StudentsScene.fxml"));
			root = loader.load();
			stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
			scene = new Scene(root);

			stage.setScene(scene);
			stage.show();

			StudentsController studentsController = loader.getController();
			studentsController.setMain(main);
		}


		@FXML
		public void btnSwitchToCourses(ActionEvent event) throws Exception {
			FXMLLoader loader = new FXMLLoader(getClass().getResource("CoursesScene.fxml"));
			root = loader.load();
			stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
			scene = new Scene(root);

			stage.setScene(scene);
			stage.show();

			CoursesController coursesController = loader.getController();
			coursesController.setMain(main);
		}

		@FXML
		public void btnSwitchToExams(ActionEvent event) throws Exception {
			FXMLLoader loader = new FXMLLoader(getClass().getResource("ExamsScene.fxml"));
			root = loader.load();
			stage = (Stage) ((Node) event.getSource()).getScene().getWindow();
			scene = new Scene(root);

			stage.setScene(scene);
			stage.show();

			ExamsController examsController = loader.getController();
			examsController.setMain(main);
		}
	}
